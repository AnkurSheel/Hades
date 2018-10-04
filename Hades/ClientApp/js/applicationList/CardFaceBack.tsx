import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import { IJobApplications as IJobApplications1 } from './ApplicationsData';

export default class CardFaceBack extends React.Component<{ description: string }, any> {
    public render() {
        return (
            <div className='face back'>
                <div>{this.props.description}</div>
            </div>
        );
    }
}