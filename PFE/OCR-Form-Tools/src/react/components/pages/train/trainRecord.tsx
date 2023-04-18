// Copyright (c) Microsoft Corporation.
// Licensed under the MIT license.

import React from "react";
import { FontIcon } from "@fluentui/react";

export interface ITrainRecordProps {
    accuracies?: object;
    averageAccuracy?: number;
    modelInfo: {
        isComposed?: boolean;
        modelId: string;
        createdDateTime: string;
        modelName: string;
    };
}

export interface ITrainRecordState { }

export default class TrainRecord extends React.Component<ITrainRecordProps, ITrainRecordState> {
    public render() {
        return (
            <aside className="mt-3">
                <h5>Model information</h5>
                <div>
                    <h6>Model ID:</h6>
                    <p>
                        {this.props.modelInfo.modelId}
                    </p>
                    {this.props.modelInfo.modelName &&
                        <>
                            <h6>Model Name:</h6>
                            <p>
                                {this.props.modelInfo.modelName}
                            </p>
                        </>
                    }
                    <h6>Created date and time:</h6>
                    <p>
                        {new Date(this.props.modelInfo.createdDateTime).toLocaleString()}
                    </p>
                    <h6>Average accuracy:</h6>
                    <p>
                        {(this.props.averageAccuracy * 100).toFixed(2)+"%"}
                    </p>
                </div>
            </aside>
        );
    }
}
