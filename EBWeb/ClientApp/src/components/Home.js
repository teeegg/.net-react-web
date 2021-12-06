import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    constructor(props) {
        super(props);
        this.state = { isDataSaved: "", count: ""};
        this.doWork = this.doWork.bind(this);
        this.resetWork = this.resetWork.bind(this);
    }

    doWork() {
        fetch("https://localhost:5001/Tasks")
            .then(res => res.json())
            .then((data) => {
                this.setState({
                    count: data.count,
                    isDataSaved: data.isDataSaved
                });
            });
    }

    resetWork() {
        this.setState({
            count: "",
            isDataSaved: ""
        });
    }

    static renderCount() {
        return (
            <div>
                <p aria-live="polite">Is Data Saved: <strong>{this.state.isDataSaved? "Yes" : ""}</strong></p>
                <p aria-live="polite">Count: <strong>{this.state.count}</strong></p>
            </div>    
        );
        
    }

    render() {
        return (
            <div>
                <h1>Tasks</h1>
                <p>Please click the Do Work button to complete the work and click Reset to start again.</p>
                <button className="btn btn-primary mb-3" onClick={this.doWork}>Do Work</button>
                <button className="btn btn-info mb-3 ml-5" onClick={this.resetWork}>Reset</button>
                <ul>
                    <li aria-live="polite">Is Data Saved: <strong>{String(this.state.isDataSaved)}</strong></li>
                    <li aria-live="polite">Count: <strong>{this.state.count}</strong></li>
                </ul>                
            </div>  
        );
    }
}