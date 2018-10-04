import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import Card from './Card';

export interface IApplicationDetailsProps {
    key: number;
    applicationDetails: IJobApplications;
}

export default class ApplicationDetails extends React.Component<IApplicationDetailsProps, any> {
    public render() {
        return (
            <div className="columns">
                <Card applications={this.props.applicationDetails} />
            </div>
        );
    }

}