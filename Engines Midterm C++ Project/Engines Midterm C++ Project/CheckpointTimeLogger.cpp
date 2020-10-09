#include "CheckpointTimeLogger.h"

void CheckpointTimeLogger::ResetLogger()
{
	//resets and clears the logger
	m_RTBC.clear();
	m_TRT = 0.0f;
}

void CheckpointTimeLogger::SaveCheckpointTime(float RTBC)
{
	//adds the time to the vector
	m_RTBC.push_back(RTBC);

	//increments the total running time
	m_TRT += RTBC;
}

float CheckpointTimeLogger::GetTotalTime()
{
	return m_TRT;
}

float CheckpointTimeLogger::GetCheckpointTime(int index)
{
	return m_RTBC[index];
}

int CheckpointTimeLogger::GetNumCheckpoints()
{
	return m_RTBC.size();
}
