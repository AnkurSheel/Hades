import * as React from 'react'

export interface IFlipLinkProps {
    text: string;
    onFlip(): void;
}

export default class FlipLink extends React.Component<IFlipLinkProps, any> {
    constructor(props) {
        super(props);
        this.handleFlip = this.handleFlip.bind(this);
    }

    handleFlip(e) {
        this.props.onFlip();
    }

    render() {
        return (
            <a href='#' onClick={this.props.onFlip}>{this.props.text}</a>
        );
    }
}