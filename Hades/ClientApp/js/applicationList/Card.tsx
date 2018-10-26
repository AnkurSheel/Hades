import * as React from 'react'
import { IJobApplications } from './ApplicationsData';
import CardFaceFront from './CardFaceFront';
import CardFaceBack from './CardFaceBack';

export default class Card extends React.Component<{ applications: IJobApplications }, any> {
    constructor(props) {
        super(props);
        this.state = { flipped: false };
        this.handleFlip = this.handleFlip.bind(this);
    }

    handleFlip() {
        this.setState((prevState) => ({
                flipped: !prevState.flipped
            })
        );
    }

    render() {
        let cardClass = 'content';
        if (this.state.flipped) {
            cardClass += ' is-flipped';
        }
        return (
            <div className='card'>
                <div className={cardClass}>
                    <CardFaceFront applications={this.props.applications} onClicked={this.handleFlip}/>
                    <CardFaceBack description={this.props.applications.description} onClicked={this.handleFlip}/>
                </div>
            </div>
        );
    }
}