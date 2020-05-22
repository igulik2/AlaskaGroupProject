import React from "react";
import { BrowserRouter, Route, Switch } from "react-router-dom";
import CadastroCliente from "../Clientes/CadastroCliente";
import ListaClientes from "../Clientes/ListaClientes";
import ListaSabores from "../Sabores/ListaSabores";
import CadastroSabores from "../Sabores/CadastroSabores"
import NaoEncontrado from '../404/NaoEncontrado';
import Layout from '../Layout/Layout';
import EditarCasquinha from "../Casquinha/EditarCasquinha";
import ListaCasquinha from "../Casquinha/ListaCasquinha";
import CadastroCasquinha from "../Casquinha/CadastroCasquinha";
import CadastroUsuario from "../Usuarios/CadastroUsuario";
import ListaUsuario from "../Usuarios/ListaUsuarios";
import ListaAcompanhamentos from "../Acompanhamentos/ListaAcompanhamentos";
import CadastroAcompanhamento from "../Acompanhamentos/CadastroAcompanhamento";
import ListaAdicional from "../Adicional/ListaAdicional";
import CadastroAdicional from "../Adicional/CadastroAdicional";
import EditarCliente from "../Clientes/EditarCliente";
import EditarSabores from "../Sabores/EditarSabores";
import EditarUsuario from "../Usuarios/EditarUsuario";
import EditarAdicional from "../Adicional/EditarAdicional";


const Routes = () => (
    <BrowserRouter>
        <Switch>
                <Route path="/CadastroCliente" component={CadastroCliente} />
                <Route path="/ListaClientes" component={ListaClientes} />
                <Route path="/EditarCliente/:id" component={EditarCliente}/>
                <Route path="/CadastroSabores"component={CadastroSabores}/>
                <Route path="/ListaSabores"component={ListaSabores}/>
                <Route path="/EditarSabores/:id" component={EditarSabores}/>
                <Route path="/EditarCasquinha/:id" component={EditarCasquinha} />
                <Route path="/EditarUsuario/:id" component={EditarUsuario}/>
                <Route path="/CadastroCasquinha" component={CadastroCasquinha} />
                <Route path="/ListaCasquinha" component={ListaCasquinha} />
                <Route path="/CadastroUsuario" component={CadastroUsuario} />
                <Route path="/ListaUsuarios" component={ListaUsuario} />
                <Route path="/CadastroAcompanhamento" component={CadastroAcompanhamento} />
                <Route path="/ListaAcompanhamentos" component={ListaAcompanhamentos} />
                <Route path="/CadastroAdicional" component={CadastroAdicional} />
                <Route path="/ListaAdicional" component={ListaAdicional} />
                <Route path="/EditarAdicional/:id" component={EditarAdicional} />
                <Route exact path="/" component={() => <Layout><h1>Raiz do site</h1></Layout>} />
                <Route path="*" component={NaoEncontrado} />
                

        </Switch>

    </BrowserRouter>

);
 
export default Routes;