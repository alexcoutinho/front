<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VideoConverter._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <section id="fileBasket" class="video-container">

        <input type="file" class="input-file" id="my-file" name="Upload">
        <label tabindex="0" for="my-file" class="input-file-trigger">SELECIONE UM ARQUIVO DE VÍDEO</label>

        <div class="result">
            <p>Arquivo Selecionado:</p>
            <p class="file-return"></p>
        </div>



        <button class="converter" runat="server">CONVERTER</button>

        <%--<img id="progress" class="input-file" src="../Images/globe.gif" />--%>
        <%--<div class="progress">
            <div class="progress-bar" role="progressbar" aria-valuenow="0" aria-valuemin="0" aria-valuemax="100" style="width: 0%;">
                <span class="sr-only">0% completespan>
            </div>
        </div>--%>

        <div>
            <p>Caso nenhum arquivo seja informado, será convertido o arquivo <i>"sample.dv"</i>, armazenado no S3.</p>
        </div>
    </section>


</asp:Content>
