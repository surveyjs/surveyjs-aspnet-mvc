import React from 'react';
import { createRoot } from 'react-dom/client';
import SurveyRunnerComponent from "./SurveyComponent";

const container = document.getElementById('root');
const root = createRoot(container);

const json = window["json"] || {};

root.render(<React.StrictMode><div><SurveyRunnerComponent json={json} /></div></React.StrictMode>);