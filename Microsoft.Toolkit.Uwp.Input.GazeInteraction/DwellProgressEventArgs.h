//Copyright (c) Microsoft. All rights reserved. Licensed under the MIT license.
//See LICENSE in the project root for license information.

#pragma once
#pragma warning(disable:4453)

#include "DwellProgressState.h"

using namespace Platform;
using namespace Platform::Collections;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::Devices::Enumeration;
using namespace Windows::Devices::HumanInterfaceDevice;
using namespace Windows::UI::Core;
using namespace Windows::Devices::Input::Preview;

BEGIN_NAMESPACE_GAZE_INPUT

/// <summary>
/// TODO: harishsk
/// </summary>
public ref class DwellProgressEventArgs : public RoutedEventArgs
{
public:

    /// <summary>
    /// TODO: harishsk
    /// </summary>
    property DwellProgressState State { DwellProgressState get() { return _state; }}

    /// <summary>
    /// TODO: harishsk
    /// </summary>
    property double Progress { double get() { return _progress; }}

    /// <summary>
    /// TODO: harishsk
    /// </summary>
    property bool Handled;

internal:
	DwellProgressEventArgs(DwellProgressState state, TimeSpan elapsedDuration, TimeSpan triggerDuration)
	{
		_state = state;
        _progress = ((double)elapsedDuration.Duration) / triggerDuration.Duration;
	}
private:
    DwellProgressState _state;
    double _progress;
};

END_NAMESPACE_GAZE_INPUT