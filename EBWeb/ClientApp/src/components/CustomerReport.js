import React, { Component } from 'react';

export class CustomerReport extends Component {
    static displayName = CustomerReport.name;

    constructor(props) {
        super(props);
        this.state = { customerReportdata: [], loading: true }
    }

    componentDidMount() {
        this.populateReportData();
    }

    static renderCustomerReportTable(customerReportdata) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Customer Id.</th>
                        <th>Order Count</th>
                        <th>Order Total</th>
                    </tr>
                </thead>
                <tbody>
                    {customerReportdata.map(cr =>
                        <tr key={cr.customerId}>
                            <td>{cr.customerId}</td>
                            <td>{cr.orderCount}</td>
                            <td>$ {cr.orderTotal}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : CustomerReport.renderCustomerReportTable(this.state.customerReportdata);

        return (
            <div>
                <h1 id="tabelLabel">Customer Report</h1>
                {contents}
            </div>
        );
    }

    async populateReportData() {
        const response = await fetch("https://localhost:5001/Report/CustomerReport");
        const data = await response.json();
        this.setState({ customerReportdata: data, loading: false });
    }
}