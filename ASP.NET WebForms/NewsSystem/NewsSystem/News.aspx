<%@ Page Title="News" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="News.aspx.cs" Inherits="NewsSystem.News" %>

<asp:Content ID="ContentBody" ContentPlaceHolderID="MainContent" runat="server">
    <h1><%: this.Title %></h1>

    <h2>Most popular articles</h2>

    <asp:Repeater runat="server" ID="Repeater" ItemType="NewsSystem.Models.Article" SelectMethod="Repeater_GetData" >
        <ItemTemplate>  
            <div class="row">
                <h3><asp:HyperLink NavigateUrl='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.ID) %>' runat="server" ID="HypeLinkArticle" Text="<%#: Item.Title %>"/> <small><%#: Item.Category.Name %></small></h3>
                <p>
                    <%#: Item.Content %>
                </p>
                <p>Likes: <%#: Item.Likes %></p>
                <div>
                    <i>by <%#: Item.Author %></i>
                    <i>created on: <%#: Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>

    <h2>All categories</h2>
    <asp:ListView runat="server" ID="ListViewCategories" ItemType="NewsSystem.Models.Category" SelectMethod="ListViewCategories_GetData" GroupItemCount="2">
        <GroupTemplate>
            <div class="row">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>

            </div>
        </GroupTemplate>
        
        <ItemTemplate>
            <div class="col-md-6">
                <h3><%#: Item.Name %></h3>
                <asp:ListView runat="server" ID="RepeaterNews" ItemType="NewsSystem.Models.Article" DataSource="<%# Item.Articles %>">
                    <LayoutTemplate>
                        <ul>
                            <asp:PlaceHolder runat="server" ID="itemPlaceHolder"/>  
                        </ul>
                    </LayoutTemplate>
                    <ItemTemplate> 
                        <li>
                            <asp:HyperLink NavigateUrl='<%# string.Format("~/ArticleDetails.aspx?id={0}", Item.ID) %>' runat="server" Text='<%# string.Format(@"<strong>{0}</strong> <i>by {1}</i>", Item.Title, Item.Author) %>' />
                        </li>
                    </ItemTemplate>
                    <EmptyDataTemplate>No articles.</EmptyDataTemplate>
                </asp:ListView>
            </div>
        </ItemTemplate>
    </asp:ListView>


</asp:Content>
