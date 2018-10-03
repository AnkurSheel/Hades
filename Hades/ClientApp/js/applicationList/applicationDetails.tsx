import * as React from 'react'

export default class ApplicationDetails extends React.Component<any, any> {
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