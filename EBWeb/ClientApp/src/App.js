import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { CustomerReport } from './components/CustomerReport';
import { StoreDailyReport } from './components/StoreDailyReport'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
        <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/customer-report' component={CustomerReport} />
        <Route path='/store-daily-report' component={StoreDailyReport} />
      </Layout>
    );
  }
}
