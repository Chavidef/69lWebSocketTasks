import React, { Component } from 'react';
import { Route } from 'react-router';
import  Layout  from './components/Layout';
import Home from './Pages/Home';
import Login from './Pages/Login';
import Logout from './Pages/Logout';
import Signup from './Pages/Signup';


export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Layout>
            <Route exact path='/' component={Home} />
            <Route path='/signup' component={Signup} />
            <Route path='/login' component={Login} />
            <Route path='/logout' component={Logout} />
      </Layout>
    );
  }
}
