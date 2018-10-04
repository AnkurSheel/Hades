import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import CardFaceFront from './CardFaceFront';
import CardFaceBack from './CardFaceBack';

export default class Card extends React.Component<{ applications: IJobApplications }, any> {
    render() {
        return (
            <div className='card'>
                <div className='content'>
                <CardFaceFront applications={this.props.applications}/>
                <CardFaceBack description={this.props.applications.description}/>
                </div>
            </div>
        );
    }
}