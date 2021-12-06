import React, { Component } from 'react';

export class StoreDailyReport extends Component {
    static displayName = StoreDailyReport.name;

    constructor(props) {
        super(props);
        this.state = { storeDailyReportdata: [], loading: true }
    }

    componentDidMount() {
        this.populateReportData();
    }

    static renderStoreDailyReportTable(storeDailyReportdata) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Customer Date.</th>
                        <th>Order Count</th>
                        <th>Order Total</th>
                    </tr>
                </thead>
                <tbody>
                    {storeDailyReportdata.map(sr =>
                        <tr key={sr.orderDate}>
                            <td>{sr.orderDate}</td>
                            <td>{sr.orderCount}</td>
                            <td>$ {sr.orderTotal}</td>
                        </tr>
                    )}
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : StoreDailyReport.renderStoreDailyReportTable(this.state.storeDailyReportdata);

        return (
            <div>
                <h1 id="tabelLabel">Store Daily Report</h1>
                {contents}
            </div>
        );
    }

    async populateReportData() {
        const response = await fetch("https://localhost:5001/Report/StoreDailyReport");
        const data = await response.json();
        this.setState({ storeDailyReportdata: data, loading: false });
    }
}