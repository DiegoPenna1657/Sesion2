<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Ejercicio_Practica2.WebForm1" %>

<!DOCTYPE html>
<html>
<head>
<title>Tienda de tecnologia</title>
</head>
<body style="height: 363px; margin-bottom: 100px">
<form id="Form1" runat="server" method="POST">
<div>
<h1>TecForEve</h1>
&nbsp;Seleecionar algunos de nuestros productos <select id="Lista" runat="server"/>
<br/><br/>
<input type="submit" id="boton" runat="server" value="Aceptar"
 OnServerClick ="boton_ServerClick" />
<br/>
<br /><br />
<img id="Grafico" runat="server" />
<div style="font-weight:bold" id="Descripcion" runat="server"></div>&nbsp;
<div style="font-weight:bold" id="Precio" runat="server"></div>&nbsp;
</div>
</form>
</body>
</html>
 
 

