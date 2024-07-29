let btnAdd = document.getElementById("btnAdd");
let inputCPU = document.querySelector(".input-cpu");
let CPUinput = document.querySelector(".cpu-text");
let btnCancel = document.getElementById("btnCancel");
let list = ["Intel"];
let listCPU = document.getElementById("cpuList");

function addCPU() {
  if (btnAdd.value == "Thêm") {
    btnAdd.value = "Lưu";
    inputCPU.classList.add("open");
  } else {
    let input = CPUinput.value.trim();
    if (input == "") {
      alert("Không được để trống phần thêm hãng");
      CPUinput.focus();
    } else {
      // Kiểm tra trùng lặp
      for (let i = 0; i < list.length; i++) {
        if (input.toLowerCase() === list[i].toLowerCase()) {
          alert("Hai hãng trùng nhau");
          CPUinput.focus();
        }
      }
      // Tiến hành thêm vào mảng mới
      list.push(input);
      list = Array.from( new Set(list));

      // Loại bỏ dữ liệu cũ ở listCPU
      while (listCPU.lastElementChild) {
        listCPU.removeChild(listCPU.lastElementChild);
      }

      for (let i = 0; i < list.length; i++) {
        let option = document.createElement("option");
        option.text = list[i].trim();
        option.setAttribute("value", list[i]);
        listCPU.appendChild(option);
      }

      btnAdd.value = "Thêm";
      CPUinput.value = "";
      inputCPU.classList.remove("open");
    }
  }
}

function cancelCPU() {
  if (btnAdd.value == "Lưu") {
    btnAdd.value = "Thêm";
    CPUinput.value = "";
    inputCPU.classList.remove("open");
  }
}
