<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VideoConverter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="video-container">

        <input type="file" class="input-file" id="my-file">
        <label tabindex="0" for="my-file" class="input-file-trigger">SELECIONE OU ARRASTE UM ARQUIVO AQUI</label>

        <div class="result">
            <p>Arquivo Selecionado:</p>
            <p class="file-return"></p>
        </div>

        <button class="converter">CONVERTER</button>

    </section>


</asp:Content>
