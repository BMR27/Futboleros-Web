<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="frm_entrada.aspx.cs" Inherits="Proyecto_V.Froms.frm_entrada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    

  <style>
        .carousel-inner .item img{
            width:auto;
            margin:auto;
            height:auto;
            max-height:1400px;
        }

    </style>

    <div class="jumbotron text-center">
           <h2><asp:Label Text="" ID="lbl_mensaje" runat="server" /></h2>
    </div>

    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <ol id="olCarousel" class="carousel-indicators">
            <li data-target="" data-slide-to="0" class="active"></li>
            <li data-target="" data-slide-to="1"></li>
            <li data-target="" data-slide-to="2"></li>
            <li data-target="" data-slide-to="3"></li>
            <li data-target="" data-slide-to="4"></li>
            <li data-target="" data-slide-to="5"></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <img src="../Imagenes/inicio.jpg" />
            </div>

             <div class="item ">
                <img src="../Imagenes/imagen1.jpg" />
            </div>

             <div class="item ">
                <img src="../Imagenes/images2.jpg" />
            </div>

             <div class="item ">
                <img src="../Imagenes/imagen3.jpg" />
            </div>

             <div class="item">
                <img src="../Imagenes/images4.jpg" />
            </div>

             <div class="item">
                <img src="../Imagenes/images5.jpg" />
            </div>
        </div>

        <a class="left carousel-control" href="#myCarousel" role="button" data-slide="prev">
                <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
                <span class="sr-only">Anterior</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" role="button" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
            <span class="sr-only">Siguiente</span>
        </a>

    </div>

     <%-- <asp:Image id="Image1" runat="server" Height="500px" ImageUrl="~/Imagenes/inicio.jpg" 
      Width="1400px"  AlternateText="Imagen no disponible" ImageAlign="TextTop" />--%>

</asp:Content>
