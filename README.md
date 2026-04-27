# nuget-bt

General Bluetooth abstractions for reusable device discovery and protocol profile contracts.

## Package

- `Italbytz.Bt.Abstractions`

## Intent

This package contains protocol-agnostic contracts that can be shared by different BLE consumers,
including Thingy-focused and smart-brick-focused applications.

## Current Scope

- generic BLE device info model
- protocol profile abstraction
- characteristic mapping abstraction

## Consumers

- `artifacts/consumers/production/csharp-maui-thingy52`
- `artifacts/consumers/production/csharp-maui-smart-bricks`