﻿<%@ Page Title="Search Result for Query" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="LibrarySystem.Search" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="col-md-12">
        <h1><%: Title %> <asp:Literal runat="server" ID="LiteralSearchQuery" Mode="Encode"></asp:Literal></h1>
    </div>

    <asp:Repeater runat="server" ID="Repeater" ItemType="LibrarySystem.Models.Book" SelectMethod="Repeater_GetData">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
            <li>
                <asp:HyperLink NavigateUrl='<%# string.Format("~/BookDetails.aspx?id={0}", Item.ID) %>' runat="server" ID="HypeLinkBook" Text="<%# GetTitle(Item) %>"/>
                (Category: <%#: Item.Category.Name %>)
            </li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
    </asp:Repeater>

    <div class="back-link">
        <a href="/">Back to books</a>
    </div>
</asp:Content>
