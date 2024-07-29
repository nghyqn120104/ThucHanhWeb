let inputVXL = document.querySelector('.vxl-text');
let inputBrand = document.querySelector('.brand-text');
let inputDate = document.querySelector('.date-text');
let inputPrice = document.querySelector('.price-text');
let tableResult = document.getElementById("table");

function btnCancel() {
    inputVXL.value = "";
    inputBrand.value = "";
    inputDate.value = "";
    inputPrice.value = "";
}

function btnAdd() {
    let name = inputVXL.value.trim();
    let brand = inputBrand.value.trim();
    let date = inputDate.value.trim();
    let price = inputPrice.value.trim();

    if (checkEmptyData(name, brand, date, price)) {
        alert("Hãy nhập đầy đủ thông tin!");
        return;
    }

    if (!checkValidate(date)) {
        alert("Ngày nhập không được lớn hơn ngày hiện tại!");
        return;
    }

    let formattedDate = formatDate(date);
    let formattedPrice = formatCurrency(price);

    let rowCount = tableResult.rows.length;
    let newRow = tableResult.insertRow();

    let cellRow = newRow.insertCell(0);
    let cellName = newRow.insertCell(1);
    let cellBrand = newRow.insertCell(2);
    let cellDate = newRow.insertCell(3);
    let cellPrice = newRow.insertCell(4);

    cellRow.innerHTML = rowCount;
    cellName.innerHTML = name;
    cellBrand.innerHTML = brand;
    cellDate.innerHTML = formattedDate;
    cellPrice.innerHTML = formattedPrice;

    cellRow.classList.add("border-column");
    cellName.classList.add("border-column");
    cellBrand.classList.add("border-column");
    cellDate.classList.add("border-column");
    cellPrice.classList.add("border-column");

    btnCancel();
}

function checkEmptyData(name, brand, date, price) {
    return name === "" || brand === "" || date === "" || price === "";
}

function checkValidate(date) {
    let today = new Date();
    let inputDate = new Date(date);
    let dd = inputDate.getDate();
    let mm = (inputDate.getMonth() + 1);
    let yy = inputDate.getFullYear();

    let todayDD = today.getDate();
    let todayMM= today.getMonth() +1;
    let todayYY = today.getFullYear();
    
    if(yy < todayYY) {
        return true;
    }else if(yy == todayYY) {
        if(mm < todayMM) {
            return true;
        }else if(mm == todayMM) {
            if(dd < todayDD) {
                return true;
            }else {
                return false;
            }
        }else {
            return false;
        }
    }
    return false;
}

function formatDate(date) {
    let inputDateValue = new Date(date);
    let day = ("0" + inputDateValue.getDate()).slice(-2);
    let month = ("0" + (inputDateValue.getMonth() + 1)).slice(-2);
    let year = inputDateValue.getFullYear();
    return `${day}/${month}/${year}`;
}

function formatCurrency(amount) {
    return amount.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ".");
}