import * as React from 'react'
import { IJobApplications } from './ApplicationsData';

export interface IApplicationDetailsProps {
    key: number;
    applicationDetails: IJobApplications;
}

export default class ApplicationDetails extends React.Component<IApplicationDetailsProps, any> {
    public render() {
        return (
            <div className="columns">
                <div>{this.props.applicationDetails.companyName}</div>
                <div>{this.props.applicationDetails.date}</div>
                <div>{this.props.applicationDetails.status}</div>
            </div>
        );
    }

}