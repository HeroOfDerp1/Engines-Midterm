//Kaylyn McCune 100662337
#pragma once

#ifdef PLUGIN_EXPORT
#define PLUGIN_API __declspec(dllexport)
#elif PLUGIN_IMPORT
#define __declspec(dllimport)
#else
#define PLUGIN_API
#endif