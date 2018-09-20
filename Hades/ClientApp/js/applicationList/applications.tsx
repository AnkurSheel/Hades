import * as React from 'react';

import ApplicationDetails from './applicationDetails';

export default class MyApplications extends React.Component<any, any> {
    render() {
        return (
            <div>
                <h1> My Applications</h1>
                <div>
                    <ApplicationDetails />
                    <ApplicationDetails />
                    <ApplicationDetails />
                    <ApplicationDetails />
                </div>
            </div>
        );
    }
}