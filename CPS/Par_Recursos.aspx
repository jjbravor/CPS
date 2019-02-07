<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/LeftSiteMenu.Master" AutoEventWireup="true" CodeBehind="Par_Recursos.aspx.cs" Inherits="CPS.Par_Recursos" %>

 <asp:Content ID="Content1" ContentPlaceHolderID="Head" runat="server">
     </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
  <%-- <asp:UpdateProgress ID="UpdateProgress2" runat="server" AssociatedUpdatePanelID="UpdatePanel1">
        <ProgressTemplate>
            <div class="UpdateProgress">
                <i class='fa fa-circle-o-notch fa-spin'></i>
                <h2>Cargando...</h2>
            </div>
        </ProgressTemplate>
    </asp:UpdateProgress>--%>

    <div class="normalheader transition animated fadeIn small-header">
        <div class="hpanel">
            <div class="panel-body">
                <div id="hbreadcrumb" class="pull-right">
                    <ol class="hbreadcrumb breadcrumb">
                        <li>
                            <span>Parametros</span>
                        </li>
                        <li class="active">
                            <span>Recursos</span>
                        </li>
                    </ol>
                </div>
                <h2 class="font-light m-b-xs">Parametros</h2>
                <small>Recursos</small>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Scripts" runat="server">
</asp:Content>
