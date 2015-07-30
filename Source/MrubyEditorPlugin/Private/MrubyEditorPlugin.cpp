// Copyright 2015 Basaltic Studio. All Rights Reserved.

#include "MrubyEditorPluginPrivatePCH.h"

DEFINE_LOG_CATEGORY(LogMrubyEditorPlugin);

class FMrubyEditorPlugin : public IMrubyEditorPlugin
{
	/** IModuleInterface implementation */
	virtual void StartupModule() override;
	virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FMrubyEditorPlugin, MrubyEditorPlugin)

void FMrubyEditorPlugin::StartupModule()
{
}

void FMrubyEditorPlugin::ShutdownModule()
{
}
