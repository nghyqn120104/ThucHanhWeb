<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XuLy.aspx.cs" Inherits="Bai11.src.XuLy" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        * {
            box-sizing: border-box;
        }

        .content {
            text-align: center;
        }

        table {
            margin: auto;
        }

        table, th, td {
            border: 1px solid #333;
            border-collapse: collapse;
        }

        .dataReveal {
            padding: 8px 16px;
        }

        .empName {
            min-width: 250px;
        }

        .empBirth {
            min-width: 180px;
        }

        #addEmp {
            text-decoration: none;
            border: 1px solid #333;
            padding: 8px;
        }

        .btnAdd {
            margin-top: 128px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="content">
            <h2><b>Danh sách nhân viên</b></h2>
            <table>
                <thead>
                    <tr>
                        <th class="dataReveal stt">STT</th>
                        <th class="dataReveal empName">Họ và tên</th>
                        <th class="dataReveal empBirth">Ngày sinh</th>
                    </tr>
                </thead>
                <tbody id="tblNhanVien" runat="server"></tbody>
            </table>
            <div class="btnAdd"><a href="./MyForm.html" id="addEmp">Thêm NV</a></div>
        </div>
    </form>
</body>
</html>
