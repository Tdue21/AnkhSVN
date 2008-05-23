﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1433
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ankh.UI.MergeWizard {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Ankh.UI.MergeWizard.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        internal static System.Drawing.Bitmap ErrorImage {
            get {
                object obj = ResourceManager.GetObject("ErrorImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please wait while we retrieve the suggested merge sources....
        /// </summary>
        internal static string LoadingMergeSources {
            get {
                return ResourceManager.GetString("LoadingMergeSources", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this method to block a revision or range of revisions from being merged into this location.  For example, you might want to do this if the changes in the branch have already been manually applied to this location or you do not intend to ever merge the changes from the branch into this location..
        /// </summary>
        internal static string ManuallyRecordDescription {
            get {
                return ResourceManager.GetString("ManuallyRecordDescription", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ManuallyRecordImage {
            get {
                object obj = ResourceManager.GetObject("ManuallyRecordImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this method to unblock a revision or range of revisions that have previously been blocked from this location.  You might also use this option to manually remove the record of some revisions having been merged so that they can be merged again..
        /// </summary>
        internal static string ManuallyRemoveDescription {
            get {
                return ResourceManager.GetString("ManuallyRemoveDescription", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ManuallyRemoveImage {
            get {
                object obj = ResourceManager.GetObject("ManuallyRemoveImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The working copy is not ready for merge..
        /// </summary>
        internal static string MergeBestPracticesPageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeBestPracticesPageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Best Practices.
        /// </summary>
        internal static string MergeBestPracticesPageHeaderTitle {
            get {
                return ResourceManager.GetString("MergeBestPracticesPageHeaderTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the merge source.
        /// </summary>
        internal static string MergeSourceHeaderTitle {
            get {
                return ResourceManager.GetString("MergeSourceHeaderTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the location containing the items to be blocked from being merged..
        /// </summary>
        internal static string MergeSourceManuallyRecordPageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeSourceManuallyRecordPageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the location containing the items to unblock and allow for being merged..
        /// </summary>
        internal static string MergeSourceManuallyRemovePageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeSourceManuallyRemovePageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the location containing the items to merge..
        /// </summary>
        internal static string MergeSourceRangeOfRevisionsPageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeSourceRangeOfRevisionsPageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the location of the branch to reintegrate..
        /// </summary>
        internal static string MergeSourceReintegratePageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeSourceReintegratePageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Specify the URL and revisions containing the items to merge..
        /// </summary>
        internal static string MergeSourceTwoDifferentTreesPageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeSourceTwoDifferentTreesPageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the type of merge to perform.
        /// </summary>
        internal static string MergeTypePageHeaderMessage {
            get {
                return ResourceManager.GetString("MergeTypePageHeaderMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Select the merge type.
        /// </summary>
        internal static string MergeTypePageHeaderTitle {
            get {
                return ResourceManager.GetString("MergeTypePageHeaderTitle", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap MergeWizardHeaderImage {
            get {
                object obj = ResourceManager.GetObject("MergeWizardHeaderImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Icon MergeWizardIcon {
            get {
                object obj = ResourceManager.GetObject("MergeWizardIcon", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Merge Wizard.
        /// </summary>
        internal static string MergeWizardTitle {
            get {
                return ResourceManager.GetString("MergeWizardTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this method to catch-up a feature branch with the changes in trunk or another branch.  You can merge a specific set of revisions or all eligible revisions..
        /// </summary>
        internal static string RangeOfRevisionsDescription {
            get {
                return ResourceManager.GetString("RangeOfRevisionsDescription", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap RangeOfRevisionsImage {
            get {
                object obj = ResourceManager.GetObject("RangeOfRevisionsImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this method to merge the changes in a feature branch back to trunk or the location the branch was created from.  To use this method the working copy must not have any local modifications.  It must be at a single revision.  It must be a complete working copy and not have any switched children.  Finally, the revision of the working copy must be greater than or equal to the last revision the branch was synchronized to..
        /// </summary>
        internal static string ReintegrateABranchDescription {
            get {
                return ResourceManager.GetString("ReintegrateABranchDescription", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap ReintegrateABranchImage {
            get {
                object obj = ResourceManager.GetObject("ReintegrateABranchImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        internal static System.Drawing.Bitmap SuccessImage {
            get {
                object obj = ResourceManager.GetObject("SuccessImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Use this method to merge the differences between two URL and revision pairs into the current location.  This could be used as an alternative to the reintegrate merge scenario when you want to control the specific path and revisions that are being compared for the merge input..
        /// </summary>
        internal static string TwoDifferentTreesDescription {
            get {
                return ResourceManager.GetString("TwoDifferentTreesDescription", resourceCulture);
            }
        }
        
        internal static System.Drawing.Bitmap TwoDifferentTreesImage {
            get {
                object obj = ResourceManager.GetObject("TwoDifferentTreesImage", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}
