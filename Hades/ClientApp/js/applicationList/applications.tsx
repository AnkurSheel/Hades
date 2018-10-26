import * as React from 'react';

import ApplicationDetails from './applicationDetails';

export interface IJobApplicationSummary {
    id: number,
    companyName: string,
    date: string,
    status: string,
    description: string;
}

export interface IState {
    loading: boolean;
    applications: IJobApplicationSummary[];
}

export default class MyApplications extends React.Component<any, IState> {
    state: IState = {
        loading: false,
        applications: []
    };

    async componentDidMount() {
        this.setState({ loading: true });
        const result = await fetch('https://localhost:44351/api/jobapplicationapi/list');
        const applications = await result.json();
        this.setState({ applications, loading: false });
    }

    render() {
        return (
            <div>
                <h1> My Applications</h1>
                {this.state.loading && <div> Loading...</div>}
                {this.state.applications.map(
                    details => <ApplicationDetails key={details.id} applicationDetails={details}/>)}
            </div>
        );
    }
}