<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="usuWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="label_pagusuarios" runat="server" style="font-weight:bold" Text="Página de usuarios"></asp:Label>
    <div>
        <p>
            <asp:Label ID="label_nif" runat="server" Text="NIF:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="label_nombre" runat="server" Text="Nombre:" ></asp:Label>

            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

        </p>
        <p>
            <asp:Label ID="label_edad" runat="server" Text="Edad:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
    </div>

    <div>

        <asp:Button text="Leer" ID="buttom_Leer" runat="server" OnClick="buttom_Leer_Click"  />
        <asp:Button text="Leer Primero" ID="buttom_Primero" runat="server" OnClick="buttom_Primero_Click" />
        <asp:Button text="Leer Anterior"  ID="buttom_Anterior" runat="server" OnClick="buttom_Anterior_Click" />
        <asp:Button text="Leer Siguiente" ID="buttom_Siguiente" runat="server" OnClick="buttom_Siguiente_Click" />
        <asp:Button text="Crear"  ID="buttom_Crear" runat="server" OnClick="buttom_Crear_Click" />
        <asp:Button text="Actualizar"  ID="buttom_Actualizar" runat="server" OnClick="buttom_Actualizar_Click" />
        <asp:Button text="Borrar"  ID="buttom_Borrar" runat="server" OnClick="buttom_Borrar_Click" />

    </div>


</asp:Content>


