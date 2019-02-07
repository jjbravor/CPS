<%@ Page Title="" Language="C#" MasterPageFile="~/Templates/LeftSiteMenu.Master" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="CPS.Dashboard" %>

<asp:Content ID="Content1" ContentPlaceHolderID="Main" Runat="Server">

    <div class="normalheader transition animated fadeIn small-header">
        <div class="hpanel">
            <div class="panel-body">

                <div id="hbreadcrumb" class="pull-right">
                    <ol class="hbreadcrumb breadcrumb">
                        <li>
                            <span></span>
                        </li>
                        <li class="active">
                            <span>DASHBOARD</span>
                        </li>
                    </ol>
                </div>
                <h2 class="font-light m-b-xs">DASHBOARD</h2>
                <small></small>
            </div>
        </div>
    </div>

    <div class="content animate-panel">
        <div class="row">
            <div class="col-lg-12 text-center m-t-md">
                <h2>
                    ¡Bienvenidos!
                </h2>                
            </div>
        </div>
    </div>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Scripts" Runat="Server">
</asp:Content>
