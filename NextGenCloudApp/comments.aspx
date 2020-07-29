<%@ Page Title="" Language="C#" MasterPageFile="~/myMaster.Master" AutoEventWireup="true" CodeBehind="comments.aspx.cs" Inherits="NextGenCloudApp.comments" %>

<%@ MasterType VirtualPath="~/myMaster.Master" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajax" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <div class="adminEditContent">
            <table style="display: block; background-color: White; margin: 0px; padding: 2px; width: 100%; font-size: 11px; width: 100%;"
                cellpadding="5" cellspacing="2">
                <tr>
                    <td style="width: 110px;align-content:flex-start" >
                        <asp:Label Text="Name" runat="server" CssClass="adminSearchBox" />
                    </td>
                    <td style="width: 110px;">
                        <asp:TextBox ID="txtName" runat="server" CssClass="adminSearchBox" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtName"
                                    ErrorMessage="*" ToolTip="Please enter your Name" />
                    </td>
                </tr>
                <tr>
                    <td style="width: 110px;">
                        <asp:Label Text="Comments" runat="server" CssClass="adminSearchBox" />
                    </td>
                    <td>
                        <asp:TextBox ID="txtComments" Width="500" Height="50" runat="server" CssClass="adminSearchBox" />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtComments"
                                    ErrorMessage="*" ToolTip="Please enter your Comment"  />
                    </td>
                    <td>
                        <asp:Button ID="btnSearch" runat="server" Width="120" Text="Post" CssClass="buttonStyle"
                            OnClick="btnSearch_Click" CausesValidation="true" OnClientClick="ValidateForm()" />
                    </td>
                </tr>
            </table>
        </div>

        <div>
            <table border="2" class="adminGridListTable">
                <tr>
                    <td></td>
                </tr>
            </table>
        </div>
    </div>

    <div>
        <table border="2" class="adminGridListTable">
            <tr>
                <td>
                    <asp:GridView runat="server" ID="GridItems" AutoGenerateColumns="False" PageSize="10"
                        Width="100%" AllowPaging="True" AllowSorting="True" CellPadding="4" ForeColor="#333333"
                        GridLines="None" Font-Size="13px" Font-Names="Verdana"                       
                        DataKeyNames="name,comments">
                        
                        <RowStyle BackColor="#EFF3FB" Width="720" />
                        <Columns>
                            <asp:BoundField DataField="name" HeaderText="Name">
                                <HeaderStyle HorizontalAlign="Left" Width="100px" />
                                <ItemStyle HorizontalAlign="Left" Width="100px" />
                            </asp:BoundField>
                            <asp:BoundField DataField="comments" HeaderText="Comments">
                                <HeaderStyle HorizontalAlign="Left" Width="150px" />
                                <ItemStyle HorizontalAlign="Left" Width="150px" />
                            </asp:BoundField>
                            
                            
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#4b6c9e" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>
            </tr>
        </table>
    </div>

    <script type="text/javascript">
        function ValidateForm() {
            return true;
        }
    </script>

</asp:Content>
