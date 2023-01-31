import React from "react";
import { Model } from "survey-core";
import { Survey } from "survey-react-ui";
import "survey-core/survey.i18n.js";
import "survey-creator-core/survey-creator-core.i18n.js";
import "survey-core/defaultV2.css";

function SurveyRunnerRenderComponent(props: any) {
    const model = new Model(props.json);
    return (<Survey model={model} />);
}

export default SurveyRunnerRenderComponent;