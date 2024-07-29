<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bai10.aspx.cs" Inherits="Bai10.Bai10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            padding: 0;
            margin: 0;
            box-sizing: border-box;
        }

        .main {
            min-height: 1000px;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .content {
            min-height: 500px;
            min-width: 300px;
            display:flex;
            flex-direction: column;
        }

        #txtNoidung {
            width: 100%;
            min-height: 100px;
            padding: 10px;
        }

        #inputFile,#btnSubmit {
            margin-top: 10px;
            padding: 8px;
        }

        #errMessage {
            display:none;
            color:red;
        }
    </style>
</head>
<body>
    <form method="post" action="Bai10.aspx" id="form1" runat="server" onsubmit="return checkData()" enctype="multipart/form-data">
        <div class="main">
            <div class="content">
                <textarea id="txtNoidung" name="txtNoidung"></textarea>
                <input type="file" id="inputFile" name="inputFile" />
                <p id="errMessage"></p>
                <input type="submit" id="btnSubmit" />
            </div>
        </div>
    </form>

    <script>
        let inputText = document.getElementById("txtNoidung");
        let inputFile = document.getElementById("inputFile");
        let errMessage = document.getElementById("errMessage");

        function checkData() {
            let text = inputText.value.trim();
            let file = inputFile.value.trim();

            if (text === "" || file === "") {
                errMessage.innerHTML = "Hãy điền đầy đủ thông tin";
                errMessage.style.display = "block";
                return false;
            }
            return true;
        }
    </script>
</body>
</html>
