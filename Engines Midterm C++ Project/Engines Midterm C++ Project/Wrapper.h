#pragma once

#include "CheckpointTimeLogger.h"


#ifdef __cplusplus
extern "C"
{
#endif

	//put your functions here
	PLUGIN_API void ResetLogger();

	//save most recent chekpoint time
	PLUGIN_API void SaveCheckpointTime(float RTBC);

	//gets total time for the race
	PLUGIN_API float GetTotalTime();
	//get checkpoint time at index
	PLUGIN_API float GetCheckPointTime(int index);
	//get number of checkpoints saved
	PLUGIN_API int GetNumCheckpoint();



#ifdef __cplusplus
}
#endif