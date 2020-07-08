<%@ Page Language="C#" AutoEventWireup="true"  CodeBehind="Approve Leave.aspx.cs" Inherits="Login.Approve_Leave" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       
        &nbsp;&nbsp;&nbsp;
       
        <asp:GridView ID="GridView2" runat="server" OnRowEditing="GridView1_RowEditing" OnRowUpdating="GridView1_RowUpdating" AutoGenerateColumns="False">
             <columns>
                 <asp:TemplateField>
                     <ItemTemplate>
                         <asp:Button ID="Button1" runat="server" Text="Edit" CommandName="Edit"/>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:Button ID="Button2" runat="server" Text="Update" CommandName="Update" />
                     
                     </EditItemTemplate>

                 </asp:TemplateField>
            <asp:TemplateField HeaderText="Leave_ID">
              <ItemTemplate>
                  <asp:Label ID="Label1" runat="server" Text='<%#Eval("Leave_ID") %>'></asp:Label>
              </ItemTemplate>               
            </asp:TemplateField>
                 <asp:TemplateField HeaderText="Employee_ID">
                     <ItemTemplate>
                         <asp:Label ID="Label2" runat="server" Text='<%#Eval("Employee_ID") %>'></asp:Label>
                     </ItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="LeaveStartDate">
                     <ItemTemplate>
                         <asp:Label ID="Label3" runat="server" Text='<%#Eval("LeaveStartDate") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("LeaveStartDate") %>'></asp:TextBox>
                     </EditItemTemplate>
                 </asp:TemplateField >
                 <asp:TemplateField HeaderText="LeaveEndDate">
                     <ItemTemplate>
                         <asp:Label ID="Label4" runat="server" Text='<%#Eval("LeaveEndDate") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox2" runat="server" Text='<%#Eval("LeaveEndDate") %>'></asp:TextBox>
                     </EditItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="Reason">
                     <ItemTemplate>
                         <asp:Label ID="Label5" runat="server" Text='<%#Eval("Reason") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox3" runat="server" Text='<%#Eval("Reason") %>'></asp:TextBox>
                     </EditItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="LeaveType">
                     <ItemTemplate>
                         <asp:Label ID="Label6" runat="server" Text='<%#Eval("LeaveType") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                         <asp:TextBox ID="TextBox4" runat="server" Text='<%#Eval("LeaveType") %>'></asp:TextBox>
                     </EditItemTemplate>
                 </asp:TemplateField>
                 <asp:TemplateField HeaderText="LeaveStatus">
                     <ItemTemplate>
                         <asp:Label ID="Label7" runat="server" Text='<%#Eval("LeaveStatus") %>'></asp:Label>
                     </ItemTemplate>
                     <EditItemTemplate>
                     <asp:DropDownList ID="DropDownList1" Text='<%#Eval("LeaveStatus") %>' runat="server">
                         <asp:ListItem>Approved</asp:ListItem>
                         <asp:ListItem>Rejected</asp:ListItem>
                         <asp:ListItem>Submitted</asp:ListItem>
                         <asp:ListItem>rejected</asp:ListItem>


                     </asp:DropDownList>
                     </EditItemTemplate>
                 </asp:TemplateField>
        </columns>
                 
        </asp:GridView>
                         <asp:Button ID="Button3" runat="server" Text="Back" CommandName="Back" OnClick="Button3_Click" />

    </div>       
    </form>
</body>
</html>
