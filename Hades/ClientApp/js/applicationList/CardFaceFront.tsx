import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import FlipLink from './FlipLink';

export interface ICardFaceFrontProps {
    applications: IJobApplications;
    onClicked(): void;
}

export default class CardFaceFront extends React.Component<ICardFaceFrontProps, any> {

    render() {
        return (
            <div className='face'>
                <div>{this.props.applications.companyName}</div>
                <div>{this.props.applications.date}</div>
                <div>{this.props.applications.status}</div>
                <FlipLink onFlip={this.props.onClicked} text='More Details' />
            </div>
        );
    }
}