﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Persona.aspx.cs" Inherits="Lab09.Persona" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.4.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            <div class="col-md-8 mr-auto ml-auto">
                <div class="form-row">
                        <div class="col-md-4 mb-3">
                            <asp:Label ID="Label1" runat="server" Text="Nombre" AssociatedControlID="txtNombre"></asp:Label>
                            <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" placeholder="Ingrese nombre"></asp:TextBox>
                        </div>
                        <div class="col-md-4 mb-3">
                            <asp:Label ID="Label2" runat="server" Text="Apellido" AssociatedControlID="txtApellido"></asp:Label>
                            <asp:TextBox ID="txtApellido" runat="server" CssClass="form-control" placeholder="Ingrese apellido"></asp:TextBox>
                        </div>
                        <div class="col-md-4 mb-3">
                            <asp:Label ID="Label3" runat="server" Text="Usuario" AssociatedControlID="txtUsuario"></asp:Label>
                            <div class="input-group">
                                <div class="input-group-prepend">
                                    <span class="input-group-text" id="inputGroupPrepend2">@</span>
                                </div>    
                            <asp:TextBox ID="txtUsuario" runat="server" CssClass="form-control" placeholder="Usuario" aria-describedby="inputGroupPrepend2"></asp:TextBox>
                            </div>
                        </div>
                </div>
                <div class="form-row">
                    <div class="col-md-6 mb-3">
                        <asp:Label ID="Label4" runat="server" Text="Departamento" AssociatedControlID="ddlDepartamento"></asp:Label>
                        <asp:DropDownList ID="ddlDepartamento" runat="server" CssClass="form-control">
                            <asp:ListItem Text="Administración" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Contabilidad" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Recursos Humanos" Value="3"></asp:ListItem>
                            <asp:ListItem Text="TI" Value="4"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="col-mb-6 mb-3">
                        <asp:Label ID="Label5" runat="server" Text="Dirección" AssociatedControlID="txtDireccion"></asp:Label>
                        <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control" placeholder="Ingrese Dirección"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="form-check">
                        <asp:CheckBox ID="CheckBox1" runat="server" CssClass="form-check-input"/>
                        <asp:Label ID="Label6" runat="server" Text="Aceptar los términos y condiciones" AssociatedControlID="CheckBox1"></asp:Label>
                    </div>
                </div>
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" />    
            </div>
        </div>
        
        <div class="form-group">
            <asp:Label ID="Label0" runat="server" Text="Nombre"></asp:Label>
            <asp:TextBox ID="txtNombre0" runat="server" CssClass="form-control"></asp:TextBox>
        </div>
        <asp:Button ID="btnSaludar" runat="server" Text="Saludar" OnClick="btnSaludar_Click" CssClass="btn btn-primary" />
    </form>
</body>
</html>
