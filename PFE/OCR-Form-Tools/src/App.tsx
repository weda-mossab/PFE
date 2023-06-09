 

import React, { Fragment } from "react";
import { bindActionCreators } from "redux";
import { connect } from "react-redux";
import { BrowserRouter } from "react-router-dom";
import { ToastContainer } from "react-toastify";
import { IAppError, IApplicationState, IProject, ErrorCode } from "./models/applicationState";
import IAppErrorActions, * as appErrorActions from "./redux/actions/appErrorActions";
import { ErrorHandler } from "./react/components/common/errorHandler/errorHandler";
import { KeyboardManager } from "./react/components/common/keyboardManager/keyboardManager";

import { MainContentRouter } from "./react/components/shell/mainContentRouter";
import { Sidebar } from "./react/components/shell/sidebar";
import { StatusBarMetrics } from "./react/components/shell/statusBarMetrics";
import { TitleBar } from "./react/components/shell/titleBar";
import { getAppInsights } from './services/telemetryService';
import TelemetryProvider from "./providers/telemetry/telemetryProvider";
import "./App.scss";
import "react-toastify/dist/ReactToastify.css";

interface IAppProps {
    currentProject?: IProject;
    appError?: IAppError;
    actions?: IAppErrorActions;
}

function mapStateToProps(state: IApplicationState) {
    return {
        currentProject: state.currentProject,
        appError: state.appError,
    };
}

function mapDispatchToProps(dispatch) {
    return {
        actions: bindActionCreators(appErrorActions, dispatch),
    };
}

/**
 * @name - App
 * @description - Root level component for VoTT Application
 */
@connect(mapStateToProps, mapDispatchToProps)
export default class App extends React.Component<IAppProps> {
    appInsights: any = null;
    constructor(props, context) {
        super(props, context);
        this.state = {
            currentProject: this.props.currentProject,
        };
    }

    public componentDidCatch(error: Error) {
        this.props.actions.showError({
            errorCode: ErrorCode.GenericRenderError,
            title: error.name,
            message: error.message,
        });
    }

    public render() {
        const platform = global && global.process ? global.process.platform : "web";

        return (
            <Fragment>
                <ErrorHandler
                    error={this.props.appError}
                    onError={this.props.actions.showError}
                    onClearError={this.props.actions.clearError} />
                {/* Don't render app contents during a render error */}
                {(!this.props.appError || this.props.appError.errorCode !== ErrorCode.GenericRenderError) &&
                    <KeyboardManager>
                        <BrowserRouter>
                            <TelemetryProvider after={() => { this.appInsights = getAppInsights() }}>
                                <div className={`app-shell platform-${platform}`}>
                                    <TitleBar icon="TagGroup">

                                    </TitleBar>
                                    <div className="app-main">
                                        <Sidebar project={this.props.currentProject} />
                                        <MainContentRouter />
                                    </div>
                                    <ToastContainer className="frtt-toast-container" role="alert" />
                                </div>
                            </TelemetryProvider>
                        </BrowserRouter>
                    </KeyboardManager>
                }
            </Fragment>
        );
    }
}
