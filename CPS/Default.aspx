<%@ Page Title="" Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CPS.Default" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CPS - CardBoard Production System</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <meta http-equiv="X-UA-Compatible" content="IE=Edge" />

    <!--[if lt IE 9]>
	        <script src="Scripts/html5shiv.js"></script>
            <script src="Scripts/respond.min.js"></script>
        <![endif]-->

    <!-- Login style -->
    <%: System.Web.Optimization.Styles.Render("~/bundles/login-styles") %>
</head>
<body>
    <!--[if lt IE 9]>
            <p class="alert alert-danger">Usted esta usando un navegador <strong>desactualizado</strong>. Por favor <a href="http://browsehappy.com/">actualize tu navegador</a> para una mejor experiencia.</p>
        <![endif]-->

    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server" AsyncPostBackTimeout="6000" EnablePageMethods="true"></asp:ScriptManager>
        <asp:UpdatePanel runat="server">
            <ContentTemplate>

                <div id="alert" runat="server" class="alert alert-info" visible="false">
                    <strong id="alertTitle" runat="server"></strong>
                    <span id="alertText" runat="server"></span>
                </div>

                <div class="container">
                    <div class="form row col-xs-10 col-xs-offset-1 col-sm-8 col-sm-offset-2 col-md-6 col-md-offset-3">

                        <%--   <img runat="server" src="~/Images/TMM_logo.gif" alt="LOGO TMM" />--%>

                        <h2>CPS - Carboard                            
                            <br />
                            Production System</h2>

                        <div class="col-xs-12 col-sm-6 col-sm-offset-3">
                            <hr />
                            <asp:Image ID="imgProfile" class="img-circle m-b animated flipInX hide" alt="Avatar" runat="server" />

                            <div class="form-group text-left">
                                <label for="txbUsuario">Usuario:</label>
                                <%--OnTextChanged="txbUsuario_TextChanged"--%>
                                <asp:TextBox ID="txbUsuario" runat="server" MaxLength="50" CssClass="form-control" required="required" />
                            </div>

                            <%-- <div class="form-group text-left">    <%--AutoPostBack="True" 
                                <label for="ddl_pos">Agencia:</label>--%>
                            <%--OnSelectedIndexChanged="ddl_caja_cargar" --%>
                            <%--  <asp:DropDownList ID="ddl_pos" runat="server" AutoPostBack="True" CssClass="form-control" required="required" />
                            </div>--%>

                            <%--<div class="form-group text-left">
                                <label for="ddl_caja">Caja:</label>--%>
                            <%--OnSelectedIndexChanged="tab_pass"--%>
                            <%--   <asp:DropDownList ID="ddl_caja" runat="server" AutoPostBack="True" CssClass="form-control" required="required" />
                            </div>--%>

                            <div class="form-group text-left">
                                <label for="txt_password">Contraseña:</label>
                                <asp:TextBox ID="txbPassword" runat="server" TextMode="Password" MaxLength="50" CssClass="form-control" required="required" />
                            </div>

                            <asp:Button ID="btnIngresar" runat="server" CssClass="btn btn-danger btn-block" Text="Ingresar" OnClick="btnIngresar_Click" />
                        </div>
                    </div>
                </div>

                <footer class="footer" style="z-index: 10; position: fixed;">
                    <span style="float: right;">Versión:
                            <asp:Label ID="lblVersion" runat="server" />
                    </span>
                    BC-SOFTWARE<i class="fa fa-copyright"></i><%= DateTime.Now.Year %></footer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </form>
    <%: System.Web.Optimization.Scripts.Render("~/bundles/login") %>
</body>
</html>


