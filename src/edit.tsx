import React from 'react';
import { createRoot } from 'react-dom/client';
import SurveyCreatorComponent from "./SurveyCreatorComponent";

const container = document.getElementById('root');
const root = createRoot(container);

const json = window["json"] || {};

root.render(<React.StrictMode><div><SurveyCreatorComponent json={json} /></div></React.StrictMode>);