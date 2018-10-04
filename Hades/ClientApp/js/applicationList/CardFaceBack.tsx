import * as React from 'react'
import FlipLink from './FlipLink';

export interface ICardFaceBackProps {
    description: string;
    onClicked(): void;
}

export default class CardFaceBack extends React.Component<ICardFaceBackProps, any> {
    render() {
        return (
            <div className='face back'>
                <div>{this.props.description}</div>
                <FlipLink onFlip={this.props.onClicked} text='Back'/>
            </div>
        );
    }
}