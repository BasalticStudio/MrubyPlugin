// Copyright 2015 Basaltic Studio. All Rights Reserved.

#include "MrubyPluginPrivatePCH.h"

DEFINE_LOG_CATEGORY(LogMrubyPlugin);

class FMrubyPlugin : public IMrubyPlugin
{
    /** IModuleInterface implementation */
    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};

IMPLEMENT_MODULE(FMrubyPlugin, MrubyPlugin)

void FMrubyPlugin::StartupModule()
{
    // Do nothing now
}

void FMrubyPlugin::ShutdownModule()
{
}
