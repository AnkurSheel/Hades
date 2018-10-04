import * as React from 'react';
import * as ReactDOM from 'react-dom';

import MyApplications from './applicationList/applications';

import '../styles/card.css';


ReactDOM.render(
    <MyApplications/>,
    document.getElementById('container')
);