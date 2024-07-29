<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebChat.aspx.cs" Inherits="Bai12.src.WebChat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <frameset rows="75%,25%">
        <frameset cols="25%,75%">
            <frame name="memsArea" src="Members.aspx" />
            <frame name="messArea" src="MessageList.aspx" />
        </frameset>
        <frameset cols="100%">
            <frame name="inpArea" src="PostMsg.html" />
        </frameset>
    </frameset>
<body>
</body>
</html>
