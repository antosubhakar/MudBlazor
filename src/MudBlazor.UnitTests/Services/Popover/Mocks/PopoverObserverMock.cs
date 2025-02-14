﻿// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MudBlazor.UnitTests.Services.Popover.Mocks;

#nullable enable
internal class PopoverObserverMock : IPopoverObserver
{
    public Guid Id { get; } = Guid.NewGuid();

    public List<Guid> PopoverNotifications { get; } = new();

    public Task PopoverCollectionUpdatedNotification(IEnumerable<IMudPopoverHolder> holders)
    {
        foreach (var holder in holders)
        {
            PopoverNotifications.Add(holder.Id);
        }

        return Task.CompletedTask;
    }
}
