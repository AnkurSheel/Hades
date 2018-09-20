import * as React from 'react';

import ApplicationDetails from './applicationDetails';

export default class MyApplications extends React.Component<any, any> {
    private getApplicationDetails() {
        return [
            { id: 1, companyName: 'Company 1', date: '20/09/2018 Thursday', status: 'Applied' },
            { id: 2, companyName: 'Company 2', date: '20/09/2018 Thursday', status: 'Applied' },
            { id: 3, companyName: 'Company 3', date: '20/09/2018 Thursday', status: 'Applied' },
            { id: 4, companyName: 'Company 4', date: '20/09/2018 Thursday', status: 'Applied' }
        ];
    }

    render() {
        return (
            <div>
                <h1> My Applications</h1>
                <div>
                    {this.getApplicationDetails().map(details => <ApplicationDetails key={details.id} applicationDetails={details} />)} 
                </div>
            </div>
        );
    }
}