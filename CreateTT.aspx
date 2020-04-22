<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="CreateTT.aspx.cs" Inherits="CreateTT" %>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <center>
        <table width="80%">
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td class="tabhea">
                    <h2 align="center">
                        <asp:Label ID="Label1" runat="server" Text="Time Table"></asp:Label></h2>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
        </table>
        <table width="90%">
            <tr>
                <td>
                    <br />
                </td>
            </tr>
            <tr>
                <td>
                    <h4>
                        <asp:Label ID="Label3" runat="server" Text="Course A"></asp:Label></h4>
                </td>
            </tr>
            <tr>
                <td>
                    <hr />
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                </td>
            </tr>
        </table>
    </center>
    <center>
        <div align="center">
            <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="95%" AutoGenerateColumns="False">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />

                <Columns>
                <asp:BoundField HeaderText="Slot" DataField="Slot" />
                <asp:BoundField HeaderText="Monday" DataField="Monday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Tuesday" DataField="Tuesday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Wednesday" DataField="Wednesday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Thursday" DataField="Thursday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Friday" DataField="Friday" HtmlEncode="false"/>
                </Columns>

            </asp:GridView>
        </div>
        <br />
        
            <table width="90%">
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
                <tr>
                    <td>
                        <h4>
                            <asp:Label ID="Label2" runat="server" Text="Course B"></asp:Label></h4>
                    </td>
                </tr>
                <tr>
                    <td>
                        <hr />
                    </td>
                </tr>
                <tr>
                    <td>
                        <br />
                    </td>
                </tr>
            </table>
        </center>
        <!--===============================Course B===================================-->

        <center>
            <asp:GridView ID="GridView2" runat="server" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4" GridLines="Horizontal" Width="95%" AutoGenerateColumns="False">
                <FooterStyle BackColor="White" ForeColor="#333333" />
                <HeaderStyle BackColor="#336666" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#336666" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="White" ForeColor="#333333" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#339966" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#487575" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#275353" />

                <Columns>
                <asp:BoundField HeaderText="Slot" DataField="Slot" />
                <asp:BoundField HeaderText="Monday" DataField="Monday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Tuesday" DataField="Tuesday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Wednesday" DataField="Wednesday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Thursday" DataField="Thursday" HtmlEncode="false"/>
                <asp:BoundField HeaderText="Friday" DataField="Friday" HtmlEncode="false"/>
                </Columns>

            </asp:GridView>
            <center>
                <table width="80%">
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                    <tr>
                        <td align="center">
                            <asp:Button ID="Button1" runat="server" Text="Export To Excel Course A"
                                CssClass="btn" OnClick="Button1_Click" />
                            <asp:Button ID="Button2" runat="server" Text="Export To Excel Course B"
                                CssClass="btn" OnClick="Button2_Click" /></td>
                    </tr>
                    <tr>
                        <td>
                            <br />
                        </td>
                    </tr>
                </table>
            </center>
        </center>
</asp:Content>
