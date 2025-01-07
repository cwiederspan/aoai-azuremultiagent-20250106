using System.Diagnostics;
using System.ComponentModel;
using Microsoft.SemanticKernel;

namespace MultiAgentDemo;

internal sealed class ClipboardAccess {
    
    [KernelFunction]
    [Description("Copies the provided content to the clipboard.")]
    public static void SetClipboard(string content) {

        if (string.IsNullOrWhiteSpace(content)) {
            return;
        }

        using Process clipProcess = Process.Start(
            new ProcessStartInfo {
                FileName = "clip",
                RedirectStandardInput = true,
                UseShellExecute = false,
            });

        clipProcess.StandardInput.Write(content);
        clipProcess.StandardInput.Close();
    }
}