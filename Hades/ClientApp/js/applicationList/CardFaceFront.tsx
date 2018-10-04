import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import { IJobApplications as IJobApplications1 } from './ApplicationsData';

export default class CardFaceFront extends React.Component<{ applications: IJobApplications1 }, any> {
    public render() {
        return (
            <div className='face'>
                <div>{this.props.applications.companyName}</div>
                <div>{this.props.applications.date}</div>
                <div>{this.props.applications.status}</div>
            </div>
        );
    }
}