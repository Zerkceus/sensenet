﻿using SenseNet.ContentRepository.Storage.DataModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SenseNet.ContentRepository.InMemory
{
    public class InitialTestData : IRepositoryDataFile
    {
        private InitialTestData()
        {
        }

        public static InitialTestData Instance { get; } = new InitialTestData();

        public string PropertyTypes => @"
  Id| DataType  | Mapping| Name
----- ----------- -------- ---------------
   1| Binary    |       0| Binary
   2| Int       |       0| VersioningMode
   3| Text      |       0| Description
   4| Int       |       1| Hidden
   5| Int       |       2| InheritableVersioningMode
   6| Int       |       3| ApprovingMode
   7| Int       |       4| InheritableApprovingMode
   8| Text      |       1| AllowedChildTypes
   9| Int       |       5| TrashDisabled
  10| Int       |       6| EnableLifespan
  11| DateTime  |       0| ValidFrom
  12| DateTime  |       1| ValidTill
  13| Reference |       0| Aspects
  14| Text      |       2| AspectData
  15| Reference |       1| BrowseApplication
  16| Text      |       3| SharingData
  17| Text      |       4| ExtensionData
  18| Int       |       7| IsTaggable
  19| Text      |       5| Tags
  20| Int       |       8| IsRateable
  21| String    |       0| RateStr
  22| Currency  |       0| RateAvg
  23| Int       |       9| RateCount
  24| Text      |       6| CheckInComments
  25| Text      |       7| RejectReason
  26| String    |       1| AppName
  27| Int       |      10| Disabled
  28| Int       |      11| IsModal
  29| Int       |      12| Clear
  30| String    |       2| Scenario
  31| String    |       3| ActionTypeName
  32| String    |       4| StyleHint
  33| String    |       5| RequiredPermissions
  34| Int       |      13| DeepPermissionCheck
  35| String    |       6| IncludeBackUrl
  36| String    |       7| CacheControl
  37| String    |       8| MaxAge
  38| String    |       9| CustomUrlParameters
  39| String    |      10| StoredIcon
  40| Text      |       8| ContentListBindings
  41| Text      |       9| ContentListDefinition
  42| String    |      11| DefaultView
  43| Reference |       2| AvailableViews
  44| Reference |       3| AvailableContentTypeFields
  45| String    |      12| ListEmail
  46| String    |      13| ExchangeSubscriptionId
  47| Int       |      14| OverwriteFiles
  48| String    |      14| GroupAttachments
  49| Int       |      15| SaveOriginalEmail
  50| Reference |       4| IncomingEmailWorkflow
  51| Int       |      16| OnlyFromLocalGroups
  52| String    |      15| InboxFolder
  53| Reference |       5| OwnerWhenVisitor
  54| Text      |      10| AspectDefinition
  55| Reference |       6| FieldSettingContents
  56| Reference |       7| Link
  57| Int       |      17| WorkflowsRunning
  58| String    |      16| UserAgentPattern
  59| String    |      17| SyncGuid
  60| DateTime  |       2| LastSync
  61| String    |      18| Watermark
  62| Int       |      18| PageCount
  63| String    |      19| MimeType
  64| Text      |      11| Shapes
  65| Text      |      12| PageAttributes
  66| String    |      20| From
  67| Text      |      13| Body
  68| DateTime  |       3| Sent
  69| String    |      21| ClassName
  70| String    |      22| MethodName
  71| Text      |      14| Parameters
  72| Reference |       8| Members
  73| String    |      23| StatusCode
  74| String    |      24| RedirectUrl
  75| Int       |      19| Width
  76| Int       |      20| Height
  77| Text      |      15| Keywords
  78| DateTime  |       4| DateTaken
  79| Reference |       9| CoverImage
  80| String    |      25| ImageType
  81| String    |      26| ImageFieldName
  82| Int       |      21| Stretch
  83| String    |      27| OutputFormat
  84| String    |      28| SmoothingMode
  85| String    |      29| InterpolationMode
  86| String    |      30| PixelOffsetMode
  87| String    |      31| ResizeTypeMode
  88| String    |      32| CropVAlign
  89| String    |      33| CropHAlign
  90| Int       |      22| GlobalOnly
  91| DateTime  |       5| Date
  92| String    |      34| MemoType
  93| Reference |      10| SeeAlso
  94| Text      |      16| Query
  95| Currency  |       1| Downloads
  96| Text      |      17| SharingIds
  97| String    |      35| SharingLevelValue
  98| Reference |      11| SharedContent
  99| Int       |      23| IsActive
 100| Int       |      24| IsWallContainer
 101| Reference |      12| WorkspaceSkin
 102| Reference |      13| Manager
 103| DateTime  |       6| Deadline
 104| Int       |      25| IsCritical
 105| String    |      36| PendingUserLang
 106| String    |      37| Language
 107| Int       |      26| EnableClientBasedCulture
 108| Int       |      27| EnableUserBasedCulture
 109| Text      |      18| UrlList
 110| Reference |      14| StartPage
 111| Reference |      15| LoginPage
 112| Reference |      16| SiteSkin
 113| Int       |      28| DenyCrossSiteAccess
 114| String    |      38| EnableAutofilters
 115| String    |      39| EnableLifespanFilter
 116| DateTime  |       7| StartDate
 117| DateTime  |       8| DueDate
 118| Reference |      17| AssignedTo
 119| String    |      40| Priority
 120| String    |      41| Status
 121| Int       |      29| TaskCompletion
 122| DateTime  |       9| KeepUntil
 123| String    |      42| OriginalPath
 124| Int       |      30| WorkspaceId
 125| String    |      43| WorkspaceRelativePath
 126| Int       |      31| MinRetentionTime
 127| Int       |      32| SizeQuota
 128| Int       |      33| BagCapacity
 129| Int       |      34| Enabled
 130| String    |      44| Domain
 131| String    |      45| Email
 132| String    |      46| FullName
 133| Text      |      19| OldPasswords
 134| String    |      47| PasswordHash
 135| String    |      48| LoginName
 136| Reference |      18| Profile
 137| Reference |      19| FollowedWorkspaces
 138| DateTime  |      10| LastLoggedOut
 139| String    |      49| JobTitle
 140| Reference |      20| ImageRef
 141| Binary    |       1| ImageData
 142| String    |      50| Captcha
 143| String    |      51| Department
 144| String    |      52| Languages
 145| String    |      53| Phone
 146| String    |      54| Gender
 147| String    |      55| MaritalStatus
 148| DateTime  |      11| BirthDate
 149| Text      |      20| Education
 150| String    |      56| TwitterAccount
 151| String    |      57| FacebookURL
 152| String    |      58| LinkedInURL
";

        public string NodeTypes => @"
  Id| Name                          | ParentName                    | ClassName                                                   | Properties
----- ------------------------------- ------------------------------- ------------------------------------------------------------- ------------------------------------------
   9| ContentType                   | <null>                        | SenseNet.ContentRepository.Schema.ContentType               | [Binary]
  10| GenericContent                | <null>                        | SenseNet.ContentRepository.GenericContent                   | [VersioningMode Description Hidden InheritableVersioningMode ApprovingMode InheritableApprovingMode AllowedChildTypes TrashDisabled EnableLifespan ValidFrom ValidTill Aspects AspectData BrowseApplication SharingData ExtensionData IsTaggable Tags IsRateable RateStr RateAvg RateCount CheckInComments RejectReason]
  11| Application                   | GenericContent                | SenseNet.ApplicationModel.Application                       | [AppName Disabled IsModal Clear Scenario ActionTypeName StyleHint RequiredPermissions DeepPermissionCheck IncludeBackUrl CacheControl MaxAge CustomUrlParameters StoredIcon]
  12| FieldSettingContent           | GenericContent                | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  13| ContentLink                   | GenericContent                | SenseNet.ContentRepository.ContentLink                      | [Link]
  14| ListItem                      | GenericContent                | SenseNet.ContentRepository.GenericContent                   | []
  15| File                          | GenericContent                | SenseNet.ContentRepository.File                             | [Binary Watermark PageCount MimeType Shapes PageAttributes]
  16| Query                         | GenericContent                | SenseNet.ContentRepository.QueryContent                     | [Query]
   1| Folder                        | GenericContent                | SenseNet.ContentRepository.Folder                           | [VersioningMode Description Hidden InheritableVersioningMode ApprovingMode InheritableApprovingMode TrashDisabled EnableLifespan ValidFrom ValidTill Aspects AspectData BrowseApplication SharingData]
   2| Group                         | GenericContent                | SenseNet.ContentRepository.Group                            | [VersioningMode Description Hidden InheritableVersioningMode ApprovingMode InheritableApprovingMode AllowedChildTypes TrashDisabled EnableLifespan ValidFrom ValidTill Aspects AspectData BrowseApplication SharingData SyncGuid LastSync Members]
   3| User                          | GenericContent                | SenseNet.ContentRepository.User                             | [VersioningMode Description Hidden InheritableVersioningMode ApprovingMode InheritableApprovingMode AllowedChildTypes TrashDisabled EnableLifespan ValidFrom ValidTill Aspects AspectData BrowseApplication SharingData SyncGuid LastSync Manager Language Enabled Domain Email FullName OldPasswords PasswordHash LoginName Profile FollowedWorkspaces LastLoggedOut JobTitle ImageRef ImageData Captcha Department Languages Phone Gender MaritalStatus BirthDate Education TwitterAccount FacebookURL LinkedInURL]
  17| ApplicationOverride           | Application                   | SenseNet.ApplicationModel.Application                       | []
  18| ExportToCsvApplication        | Application                   | SenseNet.Services.ExportToCsvApplication                    | []
  19| GenericODataApplication       | Application                   | SenseNet.Portal.ApplicationModel.GenericODataApplication    | [ClassName MethodName Parameters]
  20| HttpHandlerApplication        | Application                   | SenseNet.Portal.Handlers.HttpHandlerApplication             | []
  21| HttpStatusApplication         | Application                   | SenseNet.Portal.AppModel.HttpStatusApplication              | [StatusCode RedirectUrl]
  22| ImgResizeApplication          | Application                   | SenseNet.Portal.ApplicationModel.ImgResizeApplication       | [Width Height ImageType ImageFieldName Stretch OutputFormat SmoothingMode InterpolationMode PixelOffsetMode ResizeTypeMode CropVAlign CropHAlign]
  23| RssApplication                | Application                   | SenseNet.Services.RssApplication                            | []
  24| WebServiceApplication         | Application                   | SenseNet.ApplicationModel.Application                       | [Binary]
  35| BinaryFieldSetting            | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  36| TextFieldSetting              | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  37| NumberFieldSetting            | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  38| DateTimeFieldSetting          | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  39| HyperLinkFieldSetting         | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  40| IntegerFieldSetting           | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  41| NullFieldSetting              | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  42| ReferenceFieldSetting         | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  43| XmlFieldSetting               | FieldSettingContent           | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  44| CustomListItem                | ListItem                      | SenseNet.ContentRepository.GenericContent                   | [WorkflowsRunning]
  45| Memo                          | ListItem                      | SenseNet.ContentRepository.GenericContent                   | [Date MemoType SeeAlso]
  46| Task                          | ListItem                      | SenseNet.ContentRepository.Task                             | [StartDate DueDate AssignedTo Priority Status TaskCompletion]
  47| DynamicJsonContent            | File                          | SenseNet.Portal.Handlers.DynamicJsonContent                 | []
  48| ExecutableFile                | File                          | SenseNet.ContentRepository.File                             | []
  49| HtmlTemplate                  | File                          | SenseNet.Portal.UI.HtmlTemplate                             | []
  50| Image                         | File                          | SenseNet.ContentRepository.Image                            | [Width Height Keywords DateTaken]
  51| Settings                      | File                          | SenseNet.ContentRepository.Settings                         | [GlobalOnly]
  52| SystemFile                    | File                          | SenseNet.ContentRepository.File                             | []
   4| PortalRoot                    | Folder                        | SenseNet.ContentRepository.PortalRoot                       | [VersioningMode Description Hidden InheritableVersioningMode ApprovingMode InheritableApprovingMode TrashDisabled EnableLifespan ValidFrom ValidTill Aspects AspectData BrowseApplication SharingData]
   5| SystemFolder                  | Folder                        | SenseNet.ContentRepository.SystemFolder                     | []
   6| Domains                       | Folder                        | SenseNet.ContentRepository.Folder                           | []
   7| Domain                        | Folder                        | SenseNet.ContentRepository.Domain                           | [SyncGuid LastSync]
   8| OrganizationalUnit            | Folder                        | SenseNet.ContentRepository.OrganizationalUnit               | [SyncGuid LastSync]
  25| ContentList                   | Folder                        | SenseNet.ContentRepository.ContentList                      | [ContentListBindings ContentListDefinition DefaultView AvailableViews AvailableContentTypeFields ListEmail ExchangeSubscriptionId OverwriteFiles GroupAttachments SaveOriginalEmail IncomingEmailWorkflow OnlyFromLocalGroups InboxFolder OwnerWhenVisitor]
  26| Device                        | Folder                        | SenseNet.ApplicationModel.Device                            | [UserAgentPattern]
  27| Email                         | Folder                        | SenseNet.ContentRepository.Folder                           | [From Body Sent]
  28| ProfileDomain                 | Folder                        | SenseNet.ContentRepository.Folder                           | []
  29| Profiles                      | Folder                        | SenseNet.ContentRepository.Folder                           | []
  30| RuntimeContentContainer       | Folder                        | SenseNet.ContentRepository.RuntimeContentContainer          | []
  31| Workspace                     | Folder                        | SenseNet.ContentRepository.Workspaces.Workspace             | [IsActive IsWallContainer WorkspaceSkin Manager Deadline IsCritical]
  32| Sites                         | Folder                        | SenseNet.ContentRepository.Folder                           | []
  33| SmartFolder                   | Folder                        | SenseNet.ContentRepository.SmartFolder                      | [Query EnableAutofilters EnableLifespanFilter]
  34| TrashBag                      | Folder                        | SenseNet.ContentRepository.TrashBag                         | [Link KeepUntil OriginalPath WorkspaceId WorkspaceRelativePath]
  53| SharingGroup                  | Group                         | SenseNet.ContentRepository.Group                            | [SharingIds SharingLevelValue SharedContent]
  54| GetMetadataApplication        | HttpHandlerApplication        | SenseNet.Portal.Handlers.GetMetadataApplication             | []
  62| ShortTextFieldSetting         | TextFieldSetting              | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  63| LongTextFieldSetting          | TextFieldSetting              | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  64| CurrencyFieldSetting          | NumberFieldSetting            | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  65| PreviewImage                  | Image                         | SenseNet.ContentRepository.Image                            | []
  66| IndexingSettings              | Settings                      | SenseNet.Search.IndexingSettings                            | []
  67| LoggingSettings               | Settings                      | SenseNet.ContentRepository.LoggingSettings                  | []
  68| PortalSettings                | Settings                      | SenseNet.Portal.PortalSettings                              | []
  69| Resource                      | SystemFile                    | SenseNet.ContentRepository.i18n.Resource                    | [Downloads]
  55| Resources                     | SystemFolder                  | SenseNet.ContentRepository.SystemFolder                     | []
  56| Aspect                        | ContentList                   | SenseNet.ContentRepository.Aspect                           | [AspectDefinition FieldSettingContents]
  57| ItemList                      | ContentList                   | SenseNet.ContentRepository.ContentList                      | []
  58| Library                       | ContentList                   | SenseNet.ContentRepository.ContentList                      | []
  59| Site                          | Workspace                     | SenseNet.Portal.Site                                        | [PendingUserLang Language EnableClientBasedCulture EnableUserBasedCulture UrlList StartPage LoginPage SiteSkin DenyCrossSiteAccess]
  60| TrashBin                      | Workspace                     | SenseNet.ContentRepository.TrashBin                         | [MinRetentionTime SizeQuota BagCapacity]
  61| UserProfile                   | Workspace                     | SenseNet.ContentRepository.UserProfile                      | []
  75| ChoiceFieldSetting            | ShortTextFieldSetting         | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  76| PasswordFieldSetting          | ShortTextFieldSetting         | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  70| CustomList                    | ItemList                      | SenseNet.ContentRepository.ContentList                      | []
  71| MemoList                      | ItemList                      | SenseNet.ContentRepository.ContentList                      | []
  72| TaskList                      | ItemList                      | SenseNet.ContentRepository.ContentList                      | []
  73| DocumentLibrary               | Library                       | SenseNet.ContentRepository.ContentList                      | []
  74| ImageLibrary                  | Library                       | SenseNet.ContentRepository.ContentList                      | [CoverImage]
  77| PermissionChoiceFieldSetting  | ChoiceFieldSetting            | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
  78| YesNoFieldSetting             | ChoiceFieldSetting            | SenseNet.ContentRepository.Schema.FieldSettingContent       | []
";

        public string Nodes => @"
NodeId| TypeId| Parent|  Index| MinorV| MajorV| IsSystem| Creator| Modifier| Owner | Name                                    | DisplayName                                       | Path
------- ------- -------  ------ ------- ------- --------- -------- --------- ------- ----------------------------------------- --------------------------------------------------- -------------------------------------
     1|      3|      5|      0|      1|      1|    False|       1|        1|      1| Admin                                   | """"                                              | /Root/IMS/BuiltIn/Portal/Admin
     2|      4|      0|      1|      2|      2|    False|       1|        1|      1| Root                                    | """"                                              | /Root
     3|      6|      2|      3|      3|      3|    False|       1|        1|      1| IMS                                     | Users and Groups                                  | /Root/IMS
     4|      7|      3|      0|      4|      4|    False|       1|        1|      1| BuiltIn                                 | """"                                              | /Root/IMS/BuiltIn
     5|      8|      4|      0|      5|      5|    False|       1|        1|      1| Portal                                  | """"                                              | /Root/IMS/BuiltIn/Portal
     6|      3|      5|      4|      6|      6|    False|       1|        1|      1| Visitor                                 | """"                                              | /Root/IMS/BuiltIn/Portal/Visitor
     7|      2|      5|      2|      7|      7|    False|       1|        1|      1| Administrators                          | """"                                              | /Root/IMS/BuiltIn/Portal/Administrators
     8|      2|      5|      3|      8|      8|    False|       1|        1|      1| Everyone                                | """"                                              | /Root/IMS/BuiltIn/Portal/Everyone
     9|      2|      5|      5|      9|      9|    False|       1|        1|      1| Owners                                  | """"                                              | /Root/IMS/BuiltIn/Portal/Owners
    10|      3|      5|      7|     10|     10|    False|       1|        1|      1| Somebody                                | """"                                              | /Root/IMS/BuiltIn/Portal/Somebody
    11|      2|      5|      7|     11|     11|    False|       1|        1|      1| Operators                               | """"                                              | /Root/IMS/BuiltIn/Portal/Operators
    12|      3|      5|      8|     12|     12|    False|       1|        1|      1| Startup                                 | """"                                              | /Root/IMS/BuiltIn/Portal/Startup
  1000|      5|      2|      3|     13|     13|     True|       1|        1|      1| System                                  | """"                                              | /Root/System
  1001|      5|   1000|      1|     14|     14|     True|       1|        1|      1| Schema                                  | Schema                                            | /Root/System/Schema
  1002|      5|   1001|      1|     15|     15|     True|       1|        1|      1| ContentTypes                            | ContentTypes                                      | /Root/System/Schema/ContentTypes
  1003|      5|   1000|      2|     16|     16|     True|       1|        1|      1| Settings                                | Settings                                          | /Root/System/Settings
  1004|      9|   1002|      0|     17|     17|     True|       1|        1|      1| ContentType                             | $Ctd-ContentType,DisplayName                      | /Root/System/Schema/ContentTypes/ContentType
  1005|      9|   1002|      0|     18|     18|     True|       1|        1|      1| GenericContent                          | $Ctd-GenericContent,DisplayName                   | /Root/System/Schema/ContentTypes/GenericContent
  1006|      9|   1005|      0|     19|     19|     True|       1|        1|      1| Application                             | $Ctd-Application,DisplayName                      | /Root/System/Schema/ContentTypes/GenericContent/Application
  1007|      9|   1006|      0|     20|     20|     True|       1|        1|      1| ApplicationOverride                     | $Ctd-ApplicationOverride,DisplayName              | /Root/System/Schema/ContentTypes/GenericContent/Application/ApplicationOverride
  1008|      9|   1005|      0|     21|     21|     True|       1|        1|      1| Folder                                  | $Ctd-Folder,DisplayName                           | /Root/System/Schema/ContentTypes/GenericContent/Folder
  1009|      9|   1008|      0|     22|     22|     True|       1|        1|      1| ContentList                             | $Ctd-ContentList,DisplayName                      | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList
  1010|      9|   1009|      0|     23|     23|     True|       1|        1|      1| Aspect                                  | $Ctd-Aspect,DisplayName                           | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Aspect
  1011|      9|   1005|      0|     24|     24|     True|       1|        1|      1| FieldSettingContent                     | $Ctd-FieldSettingContent,DisplayName              | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent
  1012|      9|   1011|      0|     25|     25|     True|       1|        1|      1| BinaryFieldSetting                      | $Ctd-BinaryFieldSetting,DisplayName               | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/BinaryFieldSetting
  1013|      9|   1011|      0|     26|     26|     True|       1|        1|      1| TextFieldSetting                        | $Ctd-TextFieldSetting,DisplayName                 | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting
  1014|      9|   1013|      0|     27|     27|     True|       1|        1|      1| ShortTextFieldSetting                   | $Ctd-ShortTextFieldSetting,DisplayName            | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting
  1015|      9|   1014|      0|     28|     28|     True|       1|        1|      1| ChoiceFieldSetting                      | $Ctd-ChoiceFieldSetting,DisplayName               | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting
  1016|      9|   1005|      0|     29|     29|     True|       1|        1|      1| ContentLink                             | $Ctd-ContentLink,DisplayName                      | /Root/System/Schema/ContentTypes/GenericContent/ContentLink
  1017|      9|   1011|      0|     30|     30|     True|       1|        1|      1| NumberFieldSetting                      | $Ctd-NumberFieldSetting,DisplayName               | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NumberFieldSetting
  1018|      9|   1017|      0|     31|     31|     True|       1|        1|      1| CurrencyFieldSetting                    | $Ctd-CurrencyFieldSetting,DisplayName             | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NumberFieldSetting/CurrencyFieldSetting
  1019|      9|   1009|      0|     32|     32|     True|       1|        1|      1| ItemList                                | $Ctd-ItemList,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList
  1020|      9|   1019|      0|     33|     33|     True|       1|        1|      1| CustomList                              | $Ctd-CustomList,DisplayName                       | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/CustomList
  1021|      9|   1005|      0|     34|     34|     True|       1|        1|      1| ListItem                                | $Ctd-ListItem,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/ListItem
  1022|      9|   1021|      0|     35|     35|     True|       1|        1|      1| CustomListItem                          | $Ctd-CustomListItem,DisplayName                   | /Root/System/Schema/ContentTypes/GenericContent/ListItem/CustomListItem
  1023|      9|   1011|      0|     36|     36|     True|       1|        1|      1| DateTimeFieldSetting                    | $Ctd-DateTimeFieldSetting,DisplayName             | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/DateTimeFieldSetting
  1024|      9|   1008|      0|     37|     37|     True|       1|        1|      1| Device                                  | $Ctd-Device,DisplayName                           | /Root/System/Schema/ContentTypes/GenericContent/Folder/Device
  1025|      9|   1009|      0|     38|     38|     True|       1|        1|      1| Library                                 | $Ctd-Library,DisplayName                          | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library
  1026|      9|   1025|      0|     39|     39|     True|       1|        1|      1| DocumentLibrary                         | $Ctd-DocumentLibrary,DisplayName                  | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library/DocumentLibrary
  1027|      9|   1008|      0|     40|     40|     True|       1|        1|      1| Domain                                  | $Ctd-Domain,DisplayName                           | /Root/System/Schema/ContentTypes/GenericContent/Folder/Domain
  1028|      9|   1008|      0|     41|     41|     True|       1|        1|      1| Domains                                 | $Ctd-Domains,DisplayName                          | /Root/System/Schema/ContentTypes/GenericContent/Folder/Domains
  1029|      9|   1005|      0|     42|     42|     True|       1|        1|      1| File                                    | $Ctd-File,DisplayName                             | /Root/System/Schema/ContentTypes/GenericContent/File
  1030|      9|   1029|      0|     43|     43|     True|       1|        1|      1| DynamicJsonContent                      | Dynamic JSON content                              | /Root/System/Schema/ContentTypes/GenericContent/File/DynamicJsonContent
  1031|      9|   1008|      0|     44|     44|     True|       1|        1|      1| Email                                   | $Ctd-Email,DisplayName                            | /Root/System/Schema/ContentTypes/GenericContent/Folder/Email
  1032|      9|   1029|      0|     45|     45|     True|       1|        1|      1| ExecutableFile                          | $Ctd-ExecutableFile,DisplayName                   | /Root/System/Schema/ContentTypes/GenericContent/File/ExecutableFile
  1033|      9|   1006|      0|     46|     46|     True|       1|        1|      1| ExportToCsvApplication                  | $Ctd-ExportToCsvApplication,DisplayName           | /Root/System/Schema/ContentTypes/GenericContent/Application/ExportToCsvApplication
  1034|      9|   1006|      0|     47|     47|     True|       1|        1|      1| GenericODataApplication                 | $Ctd-GenericODataApplication,DisplayName          | /Root/System/Schema/ContentTypes/GenericContent/Application/GenericODataApplication
  1035|      9|   1006|      0|     48|     48|     True|       1|        1|      1| HttpHandlerApplication                  | $Ctd-HttpHandlerApplication,DisplayName           | /Root/System/Schema/ContentTypes/GenericContent/Application/HttpHandlerApplication
  1036|      9|   1035|      0|     49|     49|     True|       1|        1|      1| GetMetadataApplication                  | GetMetadataApplication                            | /Root/System/Schema/ContentTypes/GenericContent/Application/HttpHandlerApplication/GetMetadataApplication
  1037|      9|   1005|      0|     50|     50|     True|       1|        1|      1| Group                                   | $Ctd-Group,DisplayName                            | /Root/System/Schema/ContentTypes/GenericContent/Group
  1038|      9|   1029|      0|     51|     51|     True|       1|        1|      1| HtmlTemplate                            | $Ctd-HtmlTemplate,DisplayName                     | /Root/System/Schema/ContentTypes/GenericContent/File/HtmlTemplate
  1039|      9|   1006|      0|     52|     52|     True|       1|        1|      1| HttpStatusApplication                   | $Ctd-HttpStatusApplication,DisplayName            | /Root/System/Schema/ContentTypes/GenericContent/Application/HttpStatusApplication
  1040|      9|   1011|      0|     53|     53|     True|       1|        1|      1| HyperLinkFieldSetting                   | $Ctd-HyperLinkFieldSetting,DisplayName            | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/HyperLinkFieldSetting
  1041|      9|   1029|      0|     54|     54|     True|       1|        1|      1| Image                                   | $Ctd-Image,DisplayName                            | /Root/System/Schema/ContentTypes/GenericContent/File/Image
  1042|      9|   1025|      0|     55|     55|     True|       1|        1|      1| ImageLibrary                            | $Ctd-ImageLibrary,DisplayName                     | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library/ImageLibrary
  1043|      9|   1006|      0|     56|     56|     True|       1|        1|      1| ImgResizeApplication                    | $Ctd-ImgResizeApplication,DisplayName             | /Root/System/Schema/ContentTypes/GenericContent/Application/ImgResizeApplication
  1044|      9|   1029|      0|     57|     57|     True|       1|        1|      1| Settings                                | $Ctd-Settings,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/File/Settings
  1045|      9|   1044|      0|     58|     58|     True|       1|        1|      1| IndexingSettings                        | $Ctd-IndexingSettings,DisplayName                 | /Root/System/Schema/ContentTypes/GenericContent/File/Settings/IndexingSettings
  1046|      9|   1011|      0|     59|     59|     True|       1|        1|      1| IntegerFieldSetting                     | $Ctd-IntegerFieldSetting,DisplayName              | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/IntegerFieldSetting
  1047|      9|   1044|      0|     60|     60|     True|       1|        1|      1| LoggingSettings                         | $Ctd-LoggingSettings,DisplayName                  | /Root/System/Schema/ContentTypes/GenericContent/File/Settings/LoggingSettings
  1048|      9|   1013|      0|     61|     61|     True|       1|        1|      1| LongTextFieldSetting                    | $Ctd-LongTextFieldSetting,DisplayName             | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/LongTextFieldSetting
  1049|      9|   1021|      0|     62|     62|     True|       1|        1|      1| Memo                                    | $Ctd-Memo,DisplayName                             | /Root/System/Schema/ContentTypes/GenericContent/ListItem/Memo
  1050|      9|   1019|      0|     63|     63|     True|       1|        1|      1| MemoList                                | $Ctd-MemoList,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/MemoList
  1051|      9|   1011|      0|     64|     64|     True|       1|        1|      1| NullFieldSetting                        | $Ctd-NullFieldSetting,DisplayName                 | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NullFieldSetting
  1052|      9|   1008|      0|     65|     65|     True|       1|        1|      1| OrganizationalUnit                      | $Ctd-OrganizationalUnit,DisplayName               | /Root/System/Schema/ContentTypes/GenericContent/Folder/OrganizationalUnit
  1053|      9|   1014|      0|     66|     66|     True|       1|        1|      1| PasswordFieldSetting                    | $Ctd-PasswordFieldSetting,DisplayName             | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/PasswordFieldSetting
  1054|      9|   1015|      0|     67|     67|     True|       1|        1|      1| PermissionChoiceFieldSetting            | $Ctd-PermissionChoiceFieldSetting,DisplayName     | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting/PermissionChoiceFieldSetting
  1055|      9|   1008|      0|     68|     68|     True|       1|        1|      1| PortalRoot                              | $Ctd-PortalRoot,DisplayName                       | /Root/System/Schema/ContentTypes/GenericContent/Folder/PortalRoot
  1056|      9|   1044|      0|     69|     69|     True|       1|        1|      1| PortalSettings                          | $Ctd-PortalSettings,DisplayName                   | /Root/System/Schema/ContentTypes/GenericContent/File/Settings/PortalSettings
  1057|      9|   1041|      0|     70|     70|     True|       1|        1|      1| PreviewImage                            | $Ctd-PreviewImage,DisplayName                     | /Root/System/Schema/ContentTypes/GenericContent/File/Image/PreviewImage
  1058|      9|   1008|      0|     71|     71|     True|       1|        1|      1| ProfileDomain                           | $Ctd-ProfileDomain,DisplayName                    | /Root/System/Schema/ContentTypes/GenericContent/Folder/ProfileDomain
  1059|      9|   1008|      0|     72|     72|     True|       1|        1|      1| Profiles                                | $Ctd-Profiles,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/Profiles
  1060|      9|   1005|      0|     73|     73|     True|       1|        1|      1| Query                                   | $Ctd-Query,DisplayName                            | /Root/System/Schema/ContentTypes/GenericContent/Query
  1061|      9|   1011|      0|     74|     74|     True|       1|        1|      1| ReferenceFieldSetting                   | $Ctd-ReferenceFieldSetting,DisplayName            | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/ReferenceFieldSetting
  1062|      9|   1029|      0|     75|     75|     True|       1|        1|      1| SystemFile                              | $Ctd-SystemFile,DisplayName                       | /Root/System/Schema/ContentTypes/GenericContent/File/SystemFile
  1063|      9|   1062|      0|     76|     76|     True|       1|        1|      1| Resource                                | $Ctd-Resource,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/File/SystemFile/Resource
  1064|      9|   1008|      0|     77|     77|     True|       1|        1|      1| SystemFolder                            | $Ctd-SystemFolder,DisplayName                     | /Root/System/Schema/ContentTypes/GenericContent/Folder/SystemFolder
  1065|      9|   1064|      0|     78|     78|     True|       1|        1|      1| Resources                               | $Ctd-Resources,DisplayName                        | /Root/System/Schema/ContentTypes/GenericContent/Folder/SystemFolder/Resources
  1066|      9|   1006|      0|     79|     79|     True|       1|        1|      1| RssApplication                          | $Ctd-RssApplication,DisplayName                   | /Root/System/Schema/ContentTypes/GenericContent/Application/RssApplication
  1067|      9|   1008|      0|     80|     80|     True|       1|        1|      1| RuntimeContentContainer                 | $Ctd-RuntimeContentContainer,DisplayName          | /Root/System/Schema/ContentTypes/GenericContent/Folder/RuntimeContentContainer
  1068|      9|   1037|      0|     81|     81|     True|       1|        1|      1| SharingGroup                            | SharingGroup                                      | /Root/System/Schema/ContentTypes/GenericContent/Group/SharingGroup
  1069|      9|   1008|      0|     82|     82|     True|       1|        1|      1| Workspace                               | $Ctd-Workspace,DisplayName                        | /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace
  1070|      9|   1069|      0|     83|     83|     True|       1|        1|      1| Site                                    | $Ctd-Site,DisplayName                             | /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/Site
  1071|      9|   1008|      0|     84|     84|     True|       1|        1|      1| Sites                                   | $Ctd-Sites,DisplayName                            | /Root/System/Schema/ContentTypes/GenericContent/Folder/Sites
  1072|      9|   1008|      0|     85|     85|     True|       1|        1|      1| SmartFolder                             | $Ctd-SmartFolder,DisplayName                      | /Root/System/Schema/ContentTypes/GenericContent/Folder/SmartFolder
  1073|      9|   1021|      0|     86|     86|     True|       1|        1|      1| Task                                    | $Ctd-Task,DisplayName                             | /Root/System/Schema/ContentTypes/GenericContent/ListItem/Task
  1074|      9|   1019|      0|     87|     87|     True|       1|        1|      1| TaskList                                | $Ctd-TaskList,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/TaskList
  1075|      9|   1008|      0|     88|     88|     True|       1|        1|      1| TrashBag                                | $Ctd-TrashBag,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/TrashBag
  1076|      9|   1069|      0|     89|     89|     True|       1|        1|      1| TrashBin                                | $Ctd-TrashBin,DisplayName                         | /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/TrashBin
  1077|      9|   1005|      0|     90|     90|     True|       1|        1|      1| User                                    | $Ctd-User,DisplayName                             | /Root/System/Schema/ContentTypes/GenericContent/User
  1078|      9|   1069|      0|     91|     91|     True|       1|        1|      1| UserProfile                             | $Ctd-UserProfile,DisplayName                      | /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/UserProfile
  1079|      9|   1006|      0|     92|     92|     True|       1|        1|      1| WebServiceApplication                   | $Ctd-WebServiceApplication,DisplayName            | /Root/System/Schema/ContentTypes/GenericContent/Application/WebServiceApplication
  1080|      9|   1011|      0|     93|     93|     True|       1|        1|      1| XmlFieldSetting                         | $Ctd-XmlFieldSetting,DisplayName                  | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/XmlFieldSetting
  1081|      9|   1015|      0|     94|     94|     True|       1|        1|      1| YesNoFieldSetting                       | $Ctd-YesNoFieldSetting,DisplayName                | /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting/YesNoFieldSetting
  1082|     66|   1003|      0|     95|     95|     True|       1|        1|      1| Indexing.settings                       | """"                                              | /Root/System/Settings/Indexing.settings
  1083|     67|   1003|      0|     96|     96|     True|       1|        1|      1| Logging.settings                        | """"                                              | /Root/System/Settings/Logging.settings
  1084|     51|   1003|      0|     97|     97|     True|       1|        1|      1| MailProcessor.settings                  | """"                                              | /Root/System/Settings/MailProcessor.settings
  1085|     51|   1003|      0|     98|     98|     True|       1|        1|      1| OAuth.settings                          | """"                                              | /Root/System/Settings/OAuth.settings
  1086|     68|   1003|      0|     99|     99|     True|       1|        1|      1| Portal.settings                         | """"                                              | /Root/System/Settings/Portal.settings
  1087|     51|   1003|      0|    100|    100|     True|       1|        1|      1| Sharing.settings                        | """"                                              | /Root/System/Settings/Sharing.settings
  1088|     51|   1003|      0|    101|    101|     True|       1|        1|      1| TaskManagement.settings                 | """"                                              | /Root/System/Settings/TaskManagement.settings
  1089|     51|   1003|      0|    102|    102|     True|       1|        1|      1| UserProfile.settings                    | """"                                              | /Root/System/Settings/UserProfile.settings
  1090|      5|      2|      0|    103|    103|     True|       1|        1|      1| (apps)                                  | (apps)                                            | /Root/(apps)
  1091|      1|   1090|      0|    104|    104|     True|       1|        1|      1| ContentList                             | """"                                              | /Root/(apps)/ContentList
  1092|     11|   1091|      0|    105|    105|     True|       1|        1|      1| DeleteField                             | $Action,DeleteField                               | /Root/(apps)/ContentList/DeleteField
  1093|     11|   1091|      0|    106|    106|     True|       1|        1|      1| EditField                               | $Action,EditField                                 | /Root/(apps)/ContentList/EditField
  1094|     24|   1091|      0|    107|    107|     True|       1|        1|      1| ExchangeService.asmx                    | """"                                              | /Root/(apps)/ContentList/ExchangeService.asmx
  1095|      1|   1090|      0|    108|    108|     True|       1|        1|      1| File                                    | """"                                              | /Root/(apps)/File
  1096|     19|   1095|      0|    109|    109|     True|       1|        1|      1| CheckPreviews                           | Check preview images                              | /Root/(apps)/File/CheckPreviews
  1097|     11|   1095|      0|    110|    110|     True|       1|        1|      1| EditInMicrosoftOffice                   | $Action,Edit-in-Microsoft-Office                  | /Root/(apps)/File/EditInMicrosoftOffice
  1098|     20|   1095|      0|    111|    111|     True|       1|        1|      1| ExportToPdf                             | $Action,ExportToPdf                               | /Root/(apps)/File/ExportToPdf
  1099|     19|   1095|      0|    112|    112|     True|       1|        1|      1| GetPageCount                            | Get page count                                    | /Root/(apps)/File/GetPageCount
  1100|     19|   1095|      0|    113|    113|     True|       1|        1|      1| GetPreviewsFolder                       | Get previews folder                               | /Root/(apps)/File/GetPreviewsFolder
  1101|     19|   1095|      0|    114|    114|     True|       1|        1|      1| PreviewAvailable                        | """"                                              | /Root/(apps)/File/PreviewAvailable
  1102|     19|   1095|      0|    115|    115|     True|       1|        1|      1| RegeneratePreviews                      | Regenerate preview images                         | /Root/(apps)/File/RegeneratePreviews
  1103|     19|   1095|      0|    116|    116|     True|       1|        1|      1| SetPageCount                            | Set page count                                    | /Root/(apps)/File/SetPageCount
  1104|     19|   1095|      0|    117|    117|     True|       1|        1|      1| SetPreviewStatus                        | Set preview status                                | /Root/(apps)/File/SetPreviewStatus
  1105|     11|   1095|    250|    118|    118|     True|       1|        1|      1| UploadResume                            | $Action,UploadResume                              | /Root/(apps)/File/UploadResume
  1106|      1|   1090|      0|    119|    119|     True|       1|        1|      1| Folder                                  | """"                                              | /Root/(apps)/Folder
  1107|     11|   1106|   3800|    120|    120|     True|       1|        1|      1| CopyBatch                               | $Action,CopyBatch                                 | /Root/(apps)/Folder/CopyBatch
  1108|     11|   1106|   3800|    121|    121|     True|       1|        1|      1| DeleteBatch                             | $Action,DeleteBatch                               | /Root/(apps)/Folder/DeleteBatch
  1109|     18|   1106|   5400|    122|    122|     True|       1|        1|      1| ExportToCsv                             | $Action,ExportToCsv                               | /Root/(apps)/Folder/ExportToCsv
  1110|     11|   1106|   3800|    123|    123|     True|       1|        1|      1| MoveBatch                               | $Action,MoveBatch                                 | /Root/(apps)/Folder/MoveBatch
  1111|     11|   1106|      0|    124|    124|     True|       1|        1|      1| Upload                                  | $Action,Upload                                    | /Root/(apps)/Folder/Upload
  1112|      1|   1090|      0|    125|    125|     True|       1|        1|      1| GenericContent                          | """"                                              | /Root/(apps)/GenericContent
  1113|     19|   1112|      0|    126|    126|     True|       1|        1|      1| AddAllowedChildTypes                    | """"                                              | /Root/(apps)/GenericContent/AddAllowedChildTypes
  1114|     19|   1112|      0|    127|    127|     True|       1|        1|      1| GetRelatedPermissions                   | """"                                              | /Root/(apps)/GenericContent/GetRelatedPermissions
  1115|     19|   1112|      0|    128|    128|     True|       1|        1|      1| GetSharing                              | """"                                              | /Root/(apps)/GenericContent/GetSharing
  1116|     19|   1112|      0|    129|    129|     True|       1|        1|      1| GetTemplateScript                       | """"                                              | /Root/(apps)/GenericContent/GetTemplateScript
  1117|     20|   1112|      0|    130|    130|     True|       1|        1|      1| HasPermission                           | $Action,HasPermission                             | /Root/(apps)/GenericContent/HasPermission
  1118|     19|   1112|      0|    131|    131|     True|       1|        1|      1| Login                                   | """"                                              | /Root/(apps)/GenericContent/Login
  1119|     11|   1112|   9000|    132|    132|     True|       1|        1|      1| Logout                                  | $Action,Logout                                    | /Root/(apps)/GenericContent/Logout
  1120|     11|   1112|   3800|    133|    133|     True|       1|        1|      1| MoveTo                                  | $Action,MoveTo                                    | /Root/(apps)/GenericContent/MoveTo
  1121|     11|   1112|      0|    134|    134|     True|       1|        1|      1| Publish                                 | $Action,Publish                                   | /Root/(apps)/GenericContent/Publish
  1122|     19|   1112|      0|    135|    135|     True|       1|        1|      1| RebuildIndex                            | """"                                              | /Root/(apps)/GenericContent/RebuildIndex
  1123|     19|   1112|      0|    136|    136|     True|       1|        1|      1| RebuildIndexSubtree                     | """"                                              | /Root/(apps)/GenericContent/RebuildIndexSubtree
  1124|     19|   1112|      0|    137|    137|     True|       1|        1|      1| RefreshIndexSubtree                     | """"                                              | /Root/(apps)/GenericContent/RefreshIndexSubtree
  1125|     11|   1112|      0|    138|    138|     True|       1|        1|      1| Reject                                  | $Action,Reject                                    | /Root/(apps)/GenericContent/Reject
  1126|     20|   1112|      0|    139|    139|     True|       1|        1|      1| RemoveAllAspects                        | $Action,RemoveAllAspects                          | /Root/(apps)/GenericContent/RemoveAllAspects
  1127|     19|   1112|      0|    140|    140|     True|       1|        1|      1| GetRelatedItemsOneLevel                 | """"                                              | /Root/(apps)/GenericContent/GetRelatedItemsOneLevel
  1128|     20|   1112|      0|    141|    141|     True|       1|        1|      1| RemoveAllFields                         | $Action,RemoveAllFields                           | /Root/(apps)/GenericContent/RemoveAllFields
  1129|     20|   1112|      0|    142|    142|     True|       1|        1|      1| RemoveAspects                           | $Action,RemoveAspects                             | /Root/(apps)/GenericContent/RemoveAspects
  1130|     20|   1112|      0|    143|    143|     True|       1|        1|      1| RemoveFields                            | $Action,RemoveFields                              | /Root/(apps)/GenericContent/RemoveFields
  1131|     19|   1112|      0|    144|    144|     True|       1|        1|      1| RemoveSharing                           | """"                                              | /Root/(apps)/GenericContent/RemoveSharing
  1132|     19|   1112|      0|    145|    145|     True|       1|        1|      1| ResetRecentIndexingActivities           | """"                                              | /Root/(apps)/GenericContent/ResetRecentIndexingActivities
  1133|     11|   1112|      0|    146|    146|     True|       1|        1|      1| RestoreVersion                          | $Action,RestoreVersion                            | /Root/(apps)/GenericContent/RestoreVersion
  1134|     20|   1112|      0|    147|    147|     True|       1|        1|      1| RetrieveFields                          | $Action,RetrieveFields                            | /Root/(apps)/GenericContent/RetrieveFields
  1135|     23|   1112|      0|    148|    148|     True|       1|        1|      1| Rss                                     | $Action,Rss                                       | /Root/(apps)/GenericContent/Rss
  1136|     19|   1112|      0|    149|    149|     True|       1|        1|      1| SaveQuery                               | """"                                              | /Root/(apps)/GenericContent/SaveQuery
  1137|     11|   1112|      0|    150|    150|     True|       1|        1|      1| SetPermissions                          | $Action,SetPermissions                            | /Root/(apps)/GenericContent/SetPermissions
  1138|     19|   1112|      0|    151|    151|     True|       1|        1|      1| Share                                   | """"                                              | /Root/(apps)/GenericContent/Share
  1139|     19|   1112|      0|    152|    152|     True|       1|        1|      1| StartBlobUpload                         | """"                                              | /Root/(apps)/GenericContent/StartBlobUpload
  1140|     19|   1112|      0|    153|    153|     True|       1|        1|      1| StartBlobUploadToParent                 | """"                                              | /Root/(apps)/GenericContent/StartBlobUploadToParent
  1141|     19|   1112|      0|    154|    154|     True|       1|        1|      1| TakeLockOver                            | """"                                              | /Root/(apps)/GenericContent/TakeLockOver
  1142|     19|   1112|      0|    155|    155|     True|       1|        1|      1| RemoveAllowedChildTypes                 | """"                                              | /Root/(apps)/GenericContent/RemoveAllowedChildTypes
  1143|     19|   1112|      0|    156|    156|     True|       1|        1|      1| GetRelatedItems                         | """"                                              | /Root/(apps)/GenericContent/GetRelatedItems
  1144|     19|   1112|      0|    157|    157|     True|       1|        1|      1| GetRelatedIdentitiesByPermissions       | """"                                              | /Root/(apps)/GenericContent/GetRelatedIdentitiesByPermissions
  1145|     19|   1112|      0|    158|    158|     True|       1|        1|      1| GetRelatedIdentities                    | """"                                              | /Root/(apps)/GenericContent/GetRelatedIdentities
  1146|     20|   1112|      0|    159|    159|     True|       1|        1|      1| AddAspects                              | $Action,AddAspects                                | /Root/(apps)/GenericContent/AddAspects
  1147|     20|   1112|      0|    160|    160|     True|       1|        1|      1| AddFields                               | $Action,AddFields                                 | /Root/(apps)/GenericContent/AddFields
  1148|     19|   1112|      0|    161|    161|     True|       1|        1|      1| Ancestors                               | """"                                              | /Root/(apps)/GenericContent/Ancestors
  1149|     11|   1112|      0|    162|    162|     True|       1|        1|      1| Approve                                 | $Action,Approve                                   | /Root/(apps)/GenericContent/Approve
  1150|     11|   1112|      0|    163|    163|     True|       1|        1|      1| CheckIn                                 | $Action,CheckIn                                   | /Root/(apps)/GenericContent/CheckIn
  1151|     19|   1112|      0|    164|    164|     True|       1|        1|      1| CheckIndexIntegrity                     | """"                                              | /Root/(apps)/GenericContent/CheckIndexIntegrity
  1152|     11|   1112|      0|    165|    165|     True|       1|        1|      1| CheckOut                                | $Action,CheckOut                                  | /Root/(apps)/GenericContent/CheckOut
  1153|     19|   1112|      0|    166|    166|     True|       1|        1|      1| CheckSecurityConsistency                | """"                                              | /Root/(apps)/GenericContent/CheckSecurityConsistency
  1154|     11|   1112|   3800|    167|    167|     True|       1|        1|      1| CopyTo                                  | $Action,CopyTo                                    | /Root/(apps)/GenericContent/CopyTo
  1155|     11|   1112|   6000|    168|    168|     True|       1|        1|      1| Delete                                  | $Action,Delete                                    | /Root/(apps)/GenericContent/Delete
  1156|     19|   1112|      0|    169|    169|     True|       1|        1|      1| DocumentPreviewFinalizer                | """"                                              | /Root/(apps)/GenericContent/DocumentPreviewFinalizer
  1157|     19|   1112|      0|    170|    170|     True|       1|        1|      1| FinalizeBlobUpload                      | """"                                              | /Root/(apps)/GenericContent/FinalizeBlobUpload
  1158|     19|   1112|      0|    171|    171|     True|       1|        1|      1| FinalizeContent                         | """"                                              | /Root/(apps)/GenericContent/FinalizeContent
  1159|     11|   1112|      0|    172|    172|     True|       1|        1|      1| ForceUndoCheckOut                       | $Action,ForceUndoCheckOut                         | /Root/(apps)/GenericContent/ForceUndoCheckOut
  1160|     19|   1112|      0|    173|    173|     True|       1|        1|      1| GetAllContentTypes                      | """"                                              | /Root/(apps)/GenericContent/GetAllContentTypes
  1161|     19|   1112|      0|    174|    174|     True|       1|        1|      1| GetAllowedChildTypesFromCTD             | """"                                              | /Root/(apps)/GenericContent/GetAllowedChildTypesFromCTD
  1162|     19|   1112|      0|    175|    175|     True|       1|        1|      1| GetAllowedUsers                         | """"                                              | /Root/(apps)/GenericContent/GetAllowedUsers
  1163|     19|   1112|      0|    176|    176|     True|       1|        1|      1| GetBinaryToken                          | """"                                              | /Root/(apps)/GenericContent/GetBinaryToken
  1164|     19|   1112|      0|    177|    177|     True|       1|        1|      1| GetChildrenPermissionInfo               | """"                                              | /Root/(apps)/GenericContent/GetChildrenPermissionInfo
  1165|     19|   1112|      0|    178|    178|     True|       1|        1|      1| GetExistingPreviewImages                | $Action,GetExistingPreviewImages                  | /Root/(apps)/GenericContent/GetExistingPreviewImages
  1166|     19|   1112|      0|    179|    179|     True|       1|        1|      1| GetNameFromDisplayName                  | """"                                              | /Root/(apps)/GenericContent/GetNameFromDisplayName
  1167|     19|   1112|      0|    180|    180|     True|       1|        1|      1| GetPermissionInfo                       | """"                                              | /Root/(apps)/GenericContent/GetPermissionInfo
  1168|     19|   1112|      0|    181|    181|     True|       1|        1|      1| GetPermissionOverview                   | """"                                              | /Root/(apps)/GenericContent/GetPermissionOverview
  1169|     20|   1112|      0|    182|    182|     True|       1|        1|      1| GetPermissions                          | $Action,GetPermissions                            | /Root/(apps)/GenericContent/GetPermissions
  1170|     19|   1112|      0|    183|    183|     True|       1|        1|      1| GetPreviewImages                        | $Action,GetPreviewImages                          | /Root/(apps)/GenericContent/GetPreviewImages
  1171|     19|   1112|      0|    184|    184|     True|       1|        1|      1| GetQueries                              | """"                                              | /Root/(apps)/GenericContent/GetQueries
  1172|     19|   1112|      0|    185|    185|     True|       1|        1|      1| GetQueryBuilderMetadata                 | """"                                              | /Root/(apps)/GenericContent/GetQueryBuilderMetadata
  1173|     19|   1112|      0|    186|    186|     True|       1|        1|      1| GetRecentIndexingActivities             | """"                                              | /Root/(apps)/GenericContent/GetRecentIndexingActivities
  1174|     19|   1112|      0|    187|    187|     True|       1|        1|      1| GetRecentSecurityActivities             | """"                                              | /Root/(apps)/GenericContent/GetRecentSecurityActivities
  1175|     19|   1112|      0|    188|    188|     True|       1|        1|      1| TakeOwnership                           | """"                                              | /Root/(apps)/GenericContent/TakeOwnership
  1176|     11|   1112|      0|    189|    189|     True|       1|        1|      1| UndoCheckOut                            | $Action,UndoCheckOut                              | /Root/(apps)/GenericContent/UndoCheckOut
  1177|      1|   1090|      0|    190|    190|     True|       1|        1|      1| Group                                   | """"                                              | /Root/(apps)/Group
  1178|     19|   1177|      0|    191|    191|     True|       1|        1|      1| AddMembers                              | Add members                                       | /Root/(apps)/Group/AddMembers
  1179|     19|   1177|      0|    192|    192|     True|       1|        1|      1| GetParentGroups                         | """"                                              | /Root/(apps)/Group/GetParentGroups
  1180|     19|   1177|      0|    193|    193|     True|       1|        1|      1| RemoveMembers                           | Remove members                                    | /Root/(apps)/Group/RemoveMembers
  1181|      1|   1090|      0|    194|    194|     True|       1|        1|      1| Image                                   | """"                                              | /Root/(apps)/Image
  1182|     22|   1181|      0|    195|    195|     True|       1|        1|      1| Thumbnail                               | """"                                              | /Root/(apps)/Image/Thumbnail
  1183|      1|   1090|      0|    196|    196|     True|       1|        1|      1| Link                                    | """"                                              | /Root/(apps)/Link
  1184|     11|   1183|      0|    197|    197|     True|       1|        1|      1| Browse                                  | $Action,OpenLink                                  | /Root/(apps)/Link/Browse
  1185|      1|   1090|      0|    198|    198|     True|       1|        1|      1| PortalRoot                              | """"                                              | /Root/(apps)/PortalRoot
  1186|     19|   1185|      0|    199|    199|     True|       1|        1|      1| GetSchema                               | """"                                              | /Root/(apps)/PortalRoot/GetSchema
  1187|     19|   1185|      0|    200|    200|     True|       1|        1|      1| GetVersionInfo                          | """"                                              | /Root/(apps)/PortalRoot/GetVersionInfo
  1188|      1|   1090|      0|    201|    201|     True|       1|        1|      1| PreviewImage                            | """"                                              | /Root/(apps)/PreviewImage
  1189|     19|   1188|      0|    202|    202|     True|       1|        1|      1| SetInitialPreviewProperties             | Set initial preview properties                    | /Root/(apps)/PreviewImage/SetInitialPreviewProperties
  1190|      1|   1090|      0|    203|    203|     True|       1|        1|      1| This                                    | """"                                              | /Root/(apps)/This
  1191|     19|   1190|      0|    204|    204|     True|       1|        1|      1| Decrypt                                 | """"                                              | /Root/(apps)/This/Decrypt
  1192|     19|   1190|      0|    205|    205|     True|       1|        1|      1| Encrypt                                 | """"                                              | /Root/(apps)/This/Encrypt
  1193|      1|   1090|      0|    206|    206|     True|       1|        1|      1| User                                    | """"                                              | /Root/(apps)/User
  1194|     19|   1193|      0|    207|    207|     True|       1|        1|      1| GetParentGroups                         | """"                                              | /Root/(apps)/User/GetParentGroups
  1195|     19|   1193|      0|    208|    208|     True|       1|        1|      1| Profile                                 | """"                                              | /Root/(apps)/User/Profile
  1196|     50|      1|      0|    209|    209|    False|       1|        1|      1| Admin.png                               | Admin.png                                         | /Root/IMS/BuiltIn/Portal/Admin/Admin.png
  1197|      2|      5|      0|    210|    210|    False|       1|        1|      1| ContentExplorers                        | ContentExplorers                                  | /Root/IMS/BuiltIn/Portal/ContentExplorers
  1198|      2|      5|      0|    211|    211|    False|       1|        1|      1| Developers                              | Developers                                        | /Root/IMS/BuiltIn/Portal/Developers
  1199|      2|      5|      0|    212|    212|    False|       1|        1|      1| Editors                                 | Editors                                           | /Root/IMS/BuiltIn/Portal/Editors
  1200|      2|      5|      0|    213|    213|    False|       1|        1|      1| HR                                      | HR                                                | /Root/IMS/BuiltIn/Portal/HR
  1201|      2|      5|      0|    214|    214|    False|       1|        1|      1| IdentifiedUsers                         | IdentifiedUsers                                   | /Root/IMS/BuiltIn/Portal/IdentifiedUsers
  1202|      2|      5|      0|    215|    215|    False|       1|        1|      1| PageEditors                             | PageEditors                                       | /Root/IMS/BuiltIn/Portal/PageEditors
  1203|      2|      5|      0|    216|    216|    False|       1|        1|      1| PRCViewers                              | PRCViewers                                        | /Root/IMS/BuiltIn/Portal/PRCViewers
  1204|      2|      5|      0|    217|    217|    False|       1|        1|      1| RegisteredUsers                         | RegisteredUsers                                   | /Root/IMS/BuiltIn/Portal/RegisteredUsers
  1205|      3|      5|      0|    218|    218|    False|       1|        1|      1| VirtualADUser                           | """"                                              | /Root/IMS/BuiltIn/Portal/VirtualADUser
  1206|     55|      2|      0|    219|    219|     True|       1|        1|      1| Localization                            | """"                                              | /Root/Localization
  1221|      5|   1000|      0|    234|    234|     True|       1|        1|      1| ErrorMessages                           | """"                                              | /Root/System/ErrorMessages
  1222|      5|   1221|      0|    235|    235|     True|       1|        1|      1| Default                                 | """"                                              | /Root/System/ErrorMessages/Default
  1223|     15|   1222|      0|    236|    236|     True|       1|        1|      1| Global.html                             | """"                                              | /Root/System/ErrorMessages/Default/Global.html
  1224|     15|   1222|      0|    237|    237|     True|       1|        1|      1| UserGlobal.html                         | """"                                              | /Root/System/ErrorMessages/Default/UserGlobal.html
  1225|      5|   1001|      0|    238|    238|     True|       1|        1|      1| Metadata                                | Metadata                                          | /Root/System/Schema/Metadata
  1226|      5|   1225|      0|    239|    239|     True|       1|        1|      1| TypeScript                              | TypeScript                                        | /Root/System/Schema/Metadata/TypeScript
  1227|     54|   1226|      0|    240|    240|     True|       1|        1|      1| complextypes.ts                         | """"                                              | /Root/System/Schema/Metadata/TypeScript/complextypes.ts
  1228|     54|   1226|      0|    241|    241|     True|       1|        1|      1| contenttypes.ts                         | """"                                              | /Root/System/Schema/Metadata/TypeScript/contenttypes.ts
  1229|     54|   1226|      0|    242|    242|     True|       1|        1|      1| enums.ts                                | """"                                              | /Root/System/Schema/Metadata/TypeScript/enums.ts
  1230|     54|   1226|      0|    243|    243|     True|       1|        1|      1| fieldsettings.ts                        | """"                                              | /Root/System/Schema/Metadata/TypeScript/fieldsettings.ts
  1231|     54|   1226|      0|    244|    244|     True|       1|        1|      1| meta.zip                                | """"                                              | /Root/System/Schema/Metadata/TypeScript/meta.zip
  1232|     54|   1226|      0|    245|    245|     True|       1|        1|      1| resources.ts                            | """"                                              | /Root/System/Schema/Metadata/TypeScript/resources.ts
  1233|     54|   1226|      0|    246|    246|     True|       1|        1|      1| schemas.ts                              | """"                                              | /Root/System/Schema/Metadata/TypeScript/schemas.ts
  1234|      5|   1000|      0|    247|    247|     True|       1|        1|      1| WebRoot                                 | """"                                              | /Root/System/WebRoot
  1235|     48|   1234|      0|    248|    248|     True|       1|        1|      1| binaryhandler.ashx                      | binaryhandler.ashx                                | /Root/System/WebRoot/binaryhandler.ashx
  1236|      1|   1234|      0|    249|    249|     True|       1|        1|      1| DWS                                     | DWS                                               | /Root/System/WebRoot/DWS
  1237|     48|   1236|      0|    250|    250|     True|       1|        1|      1| Dws.asmx                                | """"                                              | /Root/System/WebRoot/DWS/Dws.asmx
  1238|     48|   1236|      0|    251|    251|     True|       1|        1|      1| Fpp.ashx                                | """"                                              | /Root/System/WebRoot/DWS/Fpp.ashx
  1239|     48|   1236|      0|    252|    252|     True|       1|        1|      1| Lists.asmx                              | """"                                              | /Root/System/WebRoot/DWS/Lists.asmx
  1240|     48|   1236|      0|    253|    253|     True|       1|        1|      1| owssvr.aspx                             | """"                                              | /Root/System/WebRoot/DWS/owssvr.aspx
  1241|     48|   1236|      0|    254|    254|     True|       1|        1|      1| Versions.asmx                           | """"                                              | /Root/System/WebRoot/DWS/Versions.asmx
  1242|     48|   1236|      0|    255|    255|     True|       1|        1|      1| Webs.asmx                               | """"                                              | /Root/System/WebRoot/DWS/Webs.asmx
  1243|     48|   1234|      0|    256|    256|     True|       1|        1|      1| vsshandler.ashx                         | vsshandler.ashx                                   | /Root/System/WebRoot/vsshandler.ashx
  1244|     60|      2|      0|    257|    257|    False|       1|        1|      1| Trash                                   | """"                                              | /Root/Trash
  1245|      5|   1244|      0|    258|    258|     True|       1|        1|      1| (apps)                                  | """"                                              | /Root/Trash/(apps)
  1246|      1|   1245|      0|    259|    259|     True|       1|        1|      1| TrashBag                                | """"                                              | /Root/Trash/(apps)/TrashBag
  1247|     11|   1246|      0|    260|    260|     True|       1|        1|      1| Restore                                 | $Action,Restore                                   | /Root/Trash/(apps)/TrashBag/Restore
";

        public string Versions => @"
VersionId| NodeId| Creator| Modifier|  Version
---------- ------- -------- --------- ---------
        1|      1|       1|        1|  V1.0.A
        2|      2|       1|        1|  V1.0.A
        3|      3|       1|        1|  V1.0.A
        4|      4|       1|        1|  V1.0.A
        5|      5|       1|        1|  V1.0.A
        6|      6|       1|        1|  V1.0.A
        7|      7|       1|        1|  V1.0.A
        8|      8|       1|        1|  V1.0.A
        9|      9|       1|        1|  V1.0.A
       10|     10|       1|        1|  V1.0.A
       11|     11|       1|        1|  V1.0.A
       12|     12|       1|        1|  V1.0.A
       13|   1000|       1|        1|  V1.0.A
       14|   1001|       1|        1|  V1.0.A
       15|   1002|       1|        1|  V1.0.A
       16|   1003|       1|        1|  V1.0.A
       17|   1004|       1|        1|  V1.0.A
       18|   1005|       1|        1|  V1.0.A
       19|   1006|       1|        1|  V1.0.A
       20|   1007|       1|        1|  V1.0.A
       21|   1008|       1|        1|  V1.0.A
       22|   1009|       1|        1|  V1.0.A
       23|   1010|       1|        1|  V1.0.A
       24|   1011|       1|        1|  V1.0.A
       25|   1012|       1|        1|  V1.0.A
       26|   1013|       1|        1|  V1.0.A
       27|   1014|       1|        1|  V1.0.A
       28|   1015|       1|        1|  V1.0.A
       29|   1016|       1|        1|  V1.0.A
       30|   1017|       1|        1|  V1.0.A
       31|   1018|       1|        1|  V1.0.A
       32|   1019|       1|        1|  V1.0.A
       33|   1020|       1|        1|  V1.0.A
       34|   1021|       1|        1|  V1.0.A
       35|   1022|       1|        1|  V1.0.A
       36|   1023|       1|        1|  V1.0.A
       37|   1024|       1|        1|  V1.0.A
       38|   1025|       1|        1|  V1.0.A
       39|   1026|       1|        1|  V1.0.A
       40|   1027|       1|        1|  V1.0.A
       41|   1028|       1|        1|  V1.0.A
       42|   1029|       1|        1|  V1.0.A
       43|   1030|       1|        1|  V1.0.A
       44|   1031|       1|        1|  V1.0.A
       45|   1032|       1|        1|  V1.0.A
       46|   1033|       1|        1|  V1.0.A
       47|   1034|       1|        1|  V1.0.A
       48|   1035|       1|        1|  V1.0.A
       49|   1036|       1|        1|  V1.0.A
       50|   1037|       1|        1|  V1.0.A
       51|   1038|       1|        1|  V1.0.A
       52|   1039|       1|        1|  V1.0.A
       53|   1040|       1|        1|  V1.0.A
       54|   1041|       1|        1|  V1.0.A
       55|   1042|       1|        1|  V1.0.A
       56|   1043|       1|        1|  V1.0.A
       57|   1044|       1|        1|  V1.0.A
       58|   1045|       1|        1|  V1.0.A
       59|   1046|       1|        1|  V1.0.A
       60|   1047|       1|        1|  V1.0.A
       61|   1048|       1|        1|  V1.0.A
       62|   1049|       1|        1|  V1.0.A
       63|   1050|       1|        1|  V1.0.A
       64|   1051|       1|        1|  V1.0.A
       65|   1052|       1|        1|  V1.0.A
       66|   1053|       1|        1|  V1.0.A
       67|   1054|       1|        1|  V1.0.A
       68|   1055|       1|        1|  V1.0.A
       69|   1056|       1|        1|  V1.0.A
       70|   1057|       1|        1|  V1.0.A
       71|   1058|       1|        1|  V1.0.A
       72|   1059|       1|        1|  V1.0.A
       73|   1060|       1|        1|  V1.0.A
       74|   1061|       1|        1|  V1.0.A
       75|   1062|       1|        1|  V1.0.A
       76|   1063|       1|        1|  V1.0.A
       77|   1064|       1|        1|  V1.0.A
       78|   1065|       1|        1|  V1.0.A
       79|   1066|       1|        1|  V1.0.A
       80|   1067|       1|        1|  V1.0.A
       81|   1068|       1|        1|  V1.0.A
       82|   1069|       1|        1|  V1.0.A
       83|   1070|       1|        1|  V1.0.A
       84|   1071|       1|        1|  V1.0.A
       85|   1072|       1|        1|  V1.0.A
       86|   1073|       1|        1|  V1.0.A
       87|   1074|       1|        1|  V1.0.A
       88|   1075|       1|        1|  V1.0.A
       89|   1076|       1|        1|  V1.0.A
       90|   1077|       1|        1|  V1.0.A
       91|   1078|       1|        1|  V1.0.A
       92|   1079|       1|        1|  V1.0.A
       93|   1080|       1|        1|  V1.0.A
       94|   1081|       1|        1|  V1.0.A
       95|   1082|       1|        1|  V1.0.A
       96|   1083|       1|        1|  V1.0.A
       97|   1084|       1|        1|  V1.0.A
       98|   1085|       1|        1|  V1.0.A
       99|   1086|       1|        1|  V1.0.A
      100|   1087|       1|        1|  V1.0.A
      101|   1088|       1|        1|  V1.0.A
      102|   1089|       1|        1|  V1.0.A
      103|   1090|       1|        1|  V1.0.A
      104|   1091|       1|        1|  V1.0.A
      105|   1092|       1|        1|  V1.0.A
      106|   1093|       1|        1|  V1.0.A
      107|   1094|       1|        1|  V1.0.A
      108|   1095|       1|        1|  V1.0.A
      109|   1096|       1|        1|  V1.0.A
      110|   1097|       1|        1|  V1.0.A
      111|   1098|       1|        1|  V1.0.A
      112|   1099|       1|        1|  V1.0.A
      113|   1100|       1|        1|  V1.0.A
      114|   1101|       1|        1|  V1.0.A
      115|   1102|       1|        1|  V1.0.A
      116|   1103|       1|        1|  V1.0.A
      117|   1104|       1|        1|  V1.0.A
      118|   1105|       1|        1|  V1.0.A
      119|   1106|       1|        1|  V1.0.A
      120|   1107|       1|        1|  V1.0.A
      121|   1108|       1|        1|  V1.0.A
      122|   1109|       1|        1|  V1.0.A
      123|   1110|       1|        1|  V1.0.A
      124|   1111|       1|        1|  V1.0.A
      125|   1112|       1|        1|  V1.0.A
      126|   1113|       1|        1|  V1.0.A
      127|   1114|       1|        1|  V1.0.A
      128|   1115|       1|        1|  V1.0.A
      129|   1116|       1|        1|  V1.0.A
      130|   1117|       1|        1|  V1.0.A
      131|   1118|       1|        1|  V1.0.A
      132|   1119|       1|        1|  V1.0.A
      133|   1120|       1|        1|  V1.0.A
      134|   1121|       1|        1|  V1.0.A
      135|   1122|       1|        1|  V1.0.A
      136|   1123|       1|        1|  V1.0.A
      137|   1124|       1|        1|  V1.0.A
      138|   1125|       1|        1|  V1.0.A
      139|   1126|       1|        1|  V1.0.A
      140|   1127|       1|        1|  V1.0.A
      141|   1128|       1|        1|  V1.0.A
      142|   1129|       1|        1|  V1.0.A
      143|   1130|       1|        1|  V1.0.A
      144|   1131|       1|        1|  V1.0.A
      145|   1132|       1|        1|  V1.0.A
      146|   1133|       1|        1|  V1.0.A
      147|   1134|       1|        1|  V1.0.A
      148|   1135|       1|        1|  V1.0.A
      149|   1136|       1|        1|  V1.0.A
      150|   1137|       1|        1|  V1.0.A
      151|   1138|       1|        1|  V1.0.A
      152|   1139|       1|        1|  V1.0.A
      153|   1140|       1|        1|  V1.0.A
      154|   1141|       1|        1|  V1.0.A
      155|   1142|       1|        1|  V1.0.A
      156|   1143|       1|        1|  V1.0.A
      157|   1144|       1|        1|  V1.0.A
      158|   1145|       1|        1|  V1.0.A
      159|   1146|       1|        1|  V1.0.A
      160|   1147|       1|        1|  V1.0.A
      161|   1148|       1|        1|  V1.0.A
      162|   1149|       1|        1|  V1.0.A
      163|   1150|       1|        1|  V1.0.A
      164|   1151|       1|        1|  V1.0.A
      165|   1152|       1|        1|  V1.0.A
      166|   1153|       1|        1|  V1.0.A
      167|   1154|       1|        1|  V1.0.A
      168|   1155|       1|        1|  V1.0.A
      169|   1156|       1|        1|  V1.0.A
      170|   1157|       1|        1|  V1.0.A
      171|   1158|       1|        1|  V1.0.A
      172|   1159|       1|        1|  V1.0.A
      173|   1160|       1|        1|  V1.0.A
      174|   1161|       1|        1|  V1.0.A
      175|   1162|       1|        1|  V1.0.A
      176|   1163|       1|        1|  V1.0.A
      177|   1164|       1|        1|  V1.0.A
      178|   1165|       1|        1|  V1.0.A
      179|   1166|       1|        1|  V1.0.A
      180|   1167|       1|        1|  V1.0.A
      181|   1168|       1|        1|  V1.0.A
      182|   1169|       1|        1|  V1.0.A
      183|   1170|       1|        1|  V1.0.A
      184|   1171|       1|        1|  V1.0.A
      185|   1172|       1|        1|  V1.0.A
      186|   1173|       1|        1|  V1.0.A
      187|   1174|       1|        1|  V1.0.A
      188|   1175|       1|        1|  V1.0.A
      189|   1176|       1|        1|  V1.0.A
      190|   1177|       1|        1|  V1.0.A
      191|   1178|       1|        1|  V1.0.A
      192|   1179|       1|        1|  V1.0.A
      193|   1180|       1|        1|  V1.0.A
      194|   1181|       1|        1|  V1.0.A
      195|   1182|       1|        1|  V1.0.A
      196|   1183|       1|        1|  V1.0.A
      197|   1184|       1|        1|  V1.0.A
      198|   1185|       1|        1|  V1.0.A
      199|   1186|       1|        1|  V1.0.A
      200|   1187|       1|        1|  V1.0.A
      201|   1188|       1|        1|  V1.0.A
      202|   1189|       1|        1|  V1.0.A
      203|   1190|       1|        1|  V1.0.A
      204|   1191|       1|        1|  V1.0.A
      205|   1192|       1|        1|  V1.0.A
      206|   1193|       1|        1|  V1.0.A
      207|   1194|       1|        1|  V1.0.A
      208|   1195|       1|        1|  V1.0.A
      209|   1196|       1|        1|  V1.0.A
      210|   1197|       1|        1|  V1.0.A
      211|   1198|       1|        1|  V1.0.A
      212|   1199|       1|        1|  V1.0.A
      213|   1200|       1|        1|  V1.0.A
      214|   1201|       1|        1|  V1.0.A
      215|   1202|       1|        1|  V1.0.A
      216|   1203|       1|        1|  V1.0.A
      217|   1204|       1|        1|  V1.0.A
      218|   1205|       1|        1|  V1.0.A
      219|   1206|       1|        1|  V1.0.A
      234|   1221|       1|        1|  V1.0.A
      235|   1222|       1|        1|  V1.0.A
      236|   1223|       1|        1|  V1.0.A
      237|   1224|       1|        1|  V1.0.A
      238|   1225|       1|        1|  V1.0.A
      239|   1226|       1|        1|  V1.0.A
      240|   1227|       1|        1|  V1.0.A
      241|   1228|       1|        1|  V1.0.A
      242|   1229|       1|        1|  V1.0.A
      243|   1230|       1|        1|  V1.0.A
      244|   1231|       1|        1|  V1.0.A
      245|   1232|       1|        1|  V1.0.A
      246|   1233|       1|        1|  V1.0.A
      247|   1234|       1|        1|  V1.0.A
      248|   1235|       1|        1|  V1.0.A
      249|   1236|       1|        1|  V1.0.A
      250|   1237|       1|        1|  V1.0.A
      251|   1238|       1|        1|  V1.0.A
      252|   1239|       1|        1|  V1.0.A
      253|   1240|       1|        1|  V1.0.A
      254|   1241|       1|        1|  V1.0.A
      255|   1242|       1|        1|  V1.0.A
      256|   1243|       1|        1|  V1.0.A
      257|   1244|       1|        1|  V1.0.A
      258|   1245|       1|        1|  V1.0.A
      259|   1246|       1|        1|  V1.0.A
      260|   1247|       1|        1|  V1.0.A
";

        public string DynamicData => @"VersionId: 1
    LongTextProperties
        OldPasswords: <?xml version=""1.0"" encoding=""utf-16""?>  <ArrayOfOldPasswordData xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">    <OldPasswordData>      <ModificationDate>2018-11-14T02:54:02.7522515Z</ModificationDate>      <Hash>$2a$10$PpzkmffYtUA5XV5nekcqVOKIZUpB8HUczoFcCmTkAUtCqUH5dS5Ki</Hash>    </OldPasswordData>  </ArrayOfOldPasswordData>
    DynamicProperties
        Enabled:Int: 1
        Domain:String: BuiltIn
        FullName:String: Admin
        PasswordHash:String: $2a$10$PpzkmffYtUA5XV5nekcqVOKIZUpB8HUczoFcCmTkAUtCqUH5dS5Ki
        LoginName:String: Admin
        LastLoggedOut:DateTime: 2018-11-14T02:54:02.0000000Z
VersionId: 6
    LongTextProperties
        OldPasswords: <?xml version=""1.0"" encoding=""utf-16""?>  <ArrayOfOldPasswordData xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" />
    DynamicProperties
        Enabled:Int: 1
        Domain:String: BuiltIn
        FullName:String: Visitor
        LoginName:String: Visitor
VersionId: 7
    DynamicProperties
        Members:Reference: [1,1198]
VersionId: 10
    LongTextProperties
        OldPasswords: <?xml version=""1.0"" encoding=""utf-16""?>  <ArrayOfOldPasswordData xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">    <OldPasswordData>      <ModificationDate>2018-11-14T02:54:03.2735274Z</ModificationDate>      <Hash>$2a$10$4l2GIJAN16.vVsBDbGXeEuQVWC2KvOrBpzvk97S32SgeyWq1Tm3ke</Hash>    </OldPasswordData>  </ArrayOfOldPasswordData>
    DynamicProperties
        Enabled:Int: 1
        Domain:String: BuiltIn
        FullName:String: Somebody
        PasswordHash:String: $2a$10$4l2GIJAN16.vVsBDbGXeEuQVWC2KvOrBpzvk97S32SgeyWq1Tm3ke
        LoginName:String: Somebody
        LastLoggedOut:DateTime: 2018-11-14T02:54:03.0000000Z
VersionId: 11
    LongTextProperties
        Description: Members of this group are able to perform administrative tasks in the Content Repository - e.g. importing the creation date of content.
    DynamicProperties
        Members:Reference: [7]
VersionId: 12
    LongTextProperties
        OldPasswords: <?xml version=""1.0"" encoding=""utf-16""?>  <ArrayOfOldPasswordData xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">    <OldPasswordData>      <ModificationDate>2018-11-14T02:54:03.4916714Z</ModificationDate>      <Hash>$2a$10$Ji1vBnecMjLLL7x70y8hOOwpUsvEQf.Xyjv1D9DQ1L/G/BOiYHS2G</Hash>    </OldPasswordData>  </ArrayOfOldPasswordData>
    DynamicProperties
        Enabled:Int: 1
        Domain:String: BuiltIn
        FullName:String: Startup User
        PasswordHash:String: $2a$10$Ji1vBnecMjLLL7x70y8hOOwpUsvEQf.Xyjv1D9DQ1L/G/BOiYHS2G
        LoginName:String: Startup
        LastLoggedOut:DateTime: 2018-11-14T02:54:03.0000000Z
VersionId: 13
    DynamicProperties
        Hidden:Int: 1
VersionId: 14
    LongTextProperties
        AllowedChildTypes: SystemFolder
VersionId: 15
    LongTextProperties
        AllowedChildTypes: ContentType
VersionId: 17
    BinaryProperties
        Binary: #1, F1, 16010L, ContentType.ContentType, text/xml, /Root/System/Schema/ContentTypes/ContentType
VersionId: 18
    BinaryProperties
        Binary: #2, F2, 31386L, GenericContent.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent
VersionId: 19
    BinaryProperties
        Binary: #3, F3, 7628L, Application.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application
VersionId: 20
    BinaryProperties
        Binary: #4, F4, 421L, ApplicationOverride.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/ApplicationOverride
VersionId: 21
    BinaryProperties
        Binary: #5, F5, 1065L, Folder.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder
VersionId: 22
    BinaryProperties
        Binary: #6, F6, 8436L, ContentList.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList
VersionId: 23
    BinaryProperties
        Binary: #7, F7, 6916L, Aspect.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Aspect
VersionId: 24
    BinaryProperties
        Binary: #8, F8, 1297L, FieldSettingContent.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent
VersionId: 25
    BinaryProperties
        Binary: #9, F9, 381L, BinaryFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/BinaryFieldSetting
VersionId: 26
    BinaryProperties
        Binary: #10, F10, 390L, TextFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting
VersionId: 27
    BinaryProperties
        Binary: #11, F11, 397L, ShortTextFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting
VersionId: 28
    BinaryProperties
        Binary: #12, F12, 393L, ChoiceFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting
VersionId: 29
    BinaryProperties
        Binary: #13, F13, 1143L, ContentLink.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/ContentLink
VersionId: 30
    BinaryProperties
        Binary: #14, F14, 391L, NumberFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NumberFieldSetting
VersionId: 31
    BinaryProperties
        Binary: #15, F15, 396L, CurrencyFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NumberFieldSetting/CurrencyFieldSetting
VersionId: 32
    BinaryProperties
        Binary: #16, F16, 2002L, ItemList.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList
VersionId: 33
    BinaryProperties
        Binary: #17, F17, 472L, CustomList.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/CustomList
VersionId: 34
    BinaryProperties
        Binary: #18, F18, 1048L, ListItem.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/ListItem
VersionId: 35
    BinaryProperties
        Binary: #19, F19, 2348L, CustomListItem.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/ListItem/CustomListItem
VersionId: 36
    BinaryProperties
        Binary: #20, F20, 397L, DateTimeFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/DateTimeFieldSetting
VersionId: 37
    BinaryProperties
        Binary: #21, F21, 608L, Device.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Device
VersionId: 38
    BinaryProperties
        Binary: #22, F22, 1305L, Library.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library
VersionId: 39
    BinaryProperties
        Binary: #23, F23, 489L, DocumentLibrary.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library/DocumentLibrary
VersionId: 40
    BinaryProperties
        Binary: #24, F24, 2081L, Domain.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Domain
VersionId: 41
    BinaryProperties
        Binary: #25, F25, 449L, Domains.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Domains
VersionId: 42
    BinaryProperties
        Binary: #26, F26, 5147L, File.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File
VersionId: 43
    BinaryProperties
        Binary: #27, F27, 343L, DynamicJsonContent.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/DynamicJsonContent
VersionId: 44
    BinaryProperties
        Binary: #28, F28, 1434L, Email.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Email
VersionId: 45
    BinaryProperties
        Binary: #29, F29, 419L, ExecutableFile.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/ExecutableFile
VersionId: 46
    BinaryProperties
        Binary: #30, F30, 445L, ExportToCsvApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/ExportToCsvApplication
VersionId: 47
    BinaryProperties
        Binary: #31, F31, 1173L, GenericODataApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/GenericODataApplication
VersionId: 48
    BinaryProperties
        Binary: #32, F32, 454L, HttpHandlerApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/HttpHandlerApplication
VersionId: 49
    BinaryProperties
        Binary: #33, F33, 350L, GetMetadataApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/HttpHandlerApplication/GetMetadataApplication
VersionId: 50
    BinaryProperties
        Binary: #34, F34, 1979L, Group.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Group
VersionId: 51
    BinaryProperties
        Binary: #35, F35, 841L, HtmlTemplate.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/HtmlTemplate
VersionId: 52
    BinaryProperties
        Binary: #36, F36, 1582L, HttpStatusApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/HttpStatusApplication
VersionId: 53
    BinaryProperties
        Binary: #37, F37, 400L, HyperLinkFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/HyperLinkFieldSetting
VersionId: 54
    BinaryProperties
        Binary: #38, F38, 1573L, Image.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Image
VersionId: 55
    BinaryProperties
        Binary: #39, F39, 1031L, ImageLibrary.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/Library/ImageLibrary
VersionId: 56
    BinaryProperties
        Binary: #40, F40, 8975L, ImgResizeApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/ImgResizeApplication
VersionId: 57
    BinaryProperties
        Binary: #41, F41, 1638L, Settings.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Settings
VersionId: 58
    BinaryProperties
        Binary: #42, F42, 854L, IndexingSettings.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Settings/IndexingSettings
VersionId: 59
    BinaryProperties
        Binary: #43, F43, 393L, IntegerFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/IntegerFieldSetting
VersionId: 60
    BinaryProperties
        Binary: #44, F44, 387L, LoggingSettings.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Settings/LoggingSettings
VersionId: 61
    BinaryProperties
        Binary: #45, F45, 395L, LongTextFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/LongTextFieldSetting
VersionId: 62
    BinaryProperties
        Binary: #46, F46, 1792L, Memo.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/ListItem/Memo
VersionId: 63
    BinaryProperties
        Binary: #47, F47, 462L, MemoList.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/MemoList
VersionId: 64
    BinaryProperties
        Binary: #48, F48, 377L, NullFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/NullFieldSetting
VersionId: 65
    BinaryProperties
        Binary: #49, F49, 2100L, OrganizationalUnit.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/OrganizationalUnit
VersionId: 66
    BinaryProperties
        Binary: #50, F50, 400L, PasswordFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/PasswordFieldSetting
VersionId: 67
    BinaryProperties
        Binary: #51, F51, 400L, PermissionChoiceFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting/PermissionChoiceFieldSetting
VersionId: 68
    BinaryProperties
        Binary: #52, F52, 799L, PortalRoot.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/PortalRoot
VersionId: 69
    BinaryProperties
        Binary: #53, F53, 378L, PortalSettings.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Settings/PortalSettings
VersionId: 70
    BinaryProperties
        Binary: #54, F54, 508L, PreviewImage.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/Image/PreviewImage
VersionId: 71
    BinaryProperties
        Binary: #55, F55, 1262L, ProfileDomain.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ProfileDomain
VersionId: 72
    BinaryProperties
        Binary: #56, F56, 459L, Profiles.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Profiles
VersionId: 73
    BinaryProperties
        Binary: #57, F57, 1267L, Query.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Query
VersionId: 74
    BinaryProperties
        Binary: #58, F58, 400L, ReferenceFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/ReferenceFieldSetting
VersionId: 75
    BinaryProperties
        Binary: #59, F59, 630L, SystemFile.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/SystemFile
VersionId: 76
    BinaryProperties
        Binary: #60, F60, 1682L, Resource.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/File/SystemFile/Resource
VersionId: 77
    BinaryProperties
        Binary: #61, F61, 622L, SystemFolder.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/SystemFolder
VersionId: 78
    BinaryProperties
        Binary: #62, F62, 469L, Resources.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/SystemFolder/Resources
VersionId: 79
    BinaryProperties
        Binary: #63, F63, 413L, RssApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/RssApplication
VersionId: 80
    BinaryProperties
        Binary: #64, F64, 448L, RuntimeContentContainer.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/RuntimeContentContainer
VersionId: 81
    BinaryProperties
        Binary: #65, F65, 1162L, SharingGroup.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Group/SharingGroup
VersionId: 82
    BinaryProperties
        Binary: #66, F66, 4337L, Workspace.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace
VersionId: 83
    BinaryProperties
        Binary: #67, F67, 6791L, Site.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/Site
VersionId: 84
    BinaryProperties
        Binary: #68, F68, 439L, Sites.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Sites
VersionId: 85
    BinaryProperties
        Binary: #69, F69, 1712L, SmartFolder.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/SmartFolder
VersionId: 86
    BinaryProperties
        Binary: #70, F70, 4383L, Task.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/ListItem/Task
VersionId: 87
    BinaryProperties
        Binary: #71, F71, 508L, TaskList.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/ContentList/ItemList/TaskList
VersionId: 88
    BinaryProperties
        Binary: #72, F72, 2662L, TrashBag.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/TrashBag
VersionId: 89
    BinaryProperties
        Binary: #73, F73, 4688L, TrashBin.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/TrashBin
VersionId: 90
    BinaryProperties
        Binary: #74, F74, 13645L, User.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/User
VersionId: 91
    BinaryProperties
        Binary: #75, F75, 2151L, UserProfile.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Folder/Workspace/UserProfile
VersionId: 92
    BinaryProperties
        Binary: #76, F76, 620L, WebServiceApplication.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/Application/WebServiceApplication
VersionId: 93
    BinaryProperties
        Binary: #77, F77, 382L, XmlFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/XmlFieldSetting
VersionId: 94
    BinaryProperties
        Binary: #78, F78, 387L, YesNoFieldSetting.ContentType, text/xml, /Root/System/Schema/ContentTypes/GenericContent/FieldSettingContent/TextFieldSetting/ShortTextFieldSetting/ChoiceFieldSetting/YesNoFieldSetting
VersionId: 95
    BinaryProperties
        Binary: #79, F79, 74L, Indexing.settings, application/octet-stream, /Root/System/Settings/Indexing.settings
    DynamicProperties
        PageCount:Int: -4
        GlobalOnly:Int: 1
VersionId: 96
    BinaryProperties
        Binary: #80, F80, 347L, Logging.settings, application/octet-stream, /Root/System/Settings/Logging.settings
    DynamicProperties
        PageCount:Int: -4
        GlobalOnly:Int: 1
VersionId: 97
    BinaryProperties
        Binary: #81, F81, 321L, MailProcessor.settings, application/octet-stream, /Root/System/Settings/MailProcessor.settings
    DynamicProperties
        PageCount:Int: -4
VersionId: 98
    BinaryProperties
        Binary: #82, F82, 43L, OAuth.settings, application/octet-stream, /Root/System/Settings/OAuth.settings
    DynamicProperties
        PageCount:Int: -4
        GlobalOnly:Int: 1
VersionId: 99
    BinaryProperties
        Binary: #83, F83, 0L, Portal.settings, application/octet-stream, /Root/System/Settings/Portal.settings
    DynamicProperties
        PageCount:Int: -4
VersionId: 100
    BinaryProperties
        Binary: #84, F84, 37L, Sharing.settings, application/octet-stream, /Root/System/Settings/Sharing.settings
    DynamicProperties
        PageCount:Int: -4
VersionId: 101
    BinaryProperties
        Binary: #85, F85, 124L, TaskManagement.settings, application/octet-stream, /Root/System/Settings/TaskManagement.settings
    DynamicProperties
        PageCount:Int: -4
        GlobalOnly:Int: 1
VersionId: 102
    BinaryProperties
        Binary: #86, F86, 65L, UserProfile.settings, application/octet-stream, /Root/System/Settings/UserProfile.settings
    DynamicProperties
        PageCount:Int: -4
        GlobalOnly:Int: 1
VersionId: 103
    DynamicProperties
        Hidden:Int: 1
VersionId: 105
    DynamicProperties
        AppName:String: DeleteField
        ActionTypeName:String: DeleteFieldAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: delete
VersionId: 106
    DynamicProperties
        AppName:String: EditField
        ActionTypeName:String: EditFieldAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: edit
VersionId: 107
    BinaryProperties
        Binary: #87, F87, 0L, ExchangeService.asmx, application/octet-stream, /Root/(apps)/ContentList/ExchangeService.asmx
    DynamicProperties
        AppName:String: ExchangeService
        CacheControl:String: Nondefined
        StoredIcon:String: application
VersionId: 109
    LongTextProperties
        Parameters: bool generateMissing
    DynamicProperties
        AppName:String: CheckPreviews
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: CheckPreviews
VersionId: 110
    DynamicProperties
        AppName:String: EditInMicrosoftOffice
        Scenario:String: ListItem
        ActionTypeName:String: WebdavOpenAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: application
VersionId: 111
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: ExportToPdf
        Scenario:String: ListItem;DocumentDetails
        ActionTypeName:String: ExportToPdfAction
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        StoredIcon:String: acrobat
VersionId: 112
    DynamicProperties
        AppName:String: GetPageCount
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: GetPageCount
VersionId: 113
    LongTextProperties
        Parameters: bool empty
    DynamicProperties
        AppName:String: GetPreviewsFolder
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: GetPreviewsFolder
VersionId: 114
    LongTextProperties
        Parameters: int page
    DynamicProperties
        AppName:String: PreviewAvailable
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: PreviewAvailable
VersionId: 115
    DynamicProperties
        AppName:String: RegeneratePreviews
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: RegeneratePreviews
VersionId: 116
    LongTextProperties
        Parameters: int pageCount
    DynamicProperties
        AppName:String: SetPageCount
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: SetPageCount
VersionId: 117
    LongTextProperties
        Parameters: SenseNet.Preview.PreviewStatus status
    DynamicProperties
        AppName:String: SetPreviewStatus
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: SetPreviewStatus
VersionId: 118
    DynamicProperties
        AppName:String: UploadResume
        Scenario:String: ListItem
        ActionTypeName:String: UploadResumeAction
        RequiredPermissions:String: _________________________________________________________**_____
        CacheControl:String: Nondefined
        StoredIcon:String: upload
VersionId: 120
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: CopyBatch
        Scenario:String: 
        ActionTypeName:String: CopyBatchAction
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: copy
VersionId: 121
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: DeleteBatch
        Scenario:String: GridToolbar
        ActionTypeName:String: DeleteBatchAction
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: delete
VersionId: 122
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: ExportToCsv
        Scenario:String: ListActions;ExploreActions
        ActionTypeName:String: 
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: download
VersionId: 123
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: MoveBatch
        Scenario:String: GridToolbar
        ActionTypeName:String: MoveBatchAction
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: move
VersionId: 124
    DynamicProperties
        AppName:String: Upload
        ActionTypeName:String: UploadAction
        RequiredPermissions:String: ______________________________________________________*____*___*
        CacheControl:String: Nondefined
        StoredIcon:String: upload
VersionId: 126
    LongTextProperties
        Parameters: string[] contentTypes
    DynamicProperties
        AppName:String: AddAllowedChildTypes
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.GenericContent
        MethodName:String: AddAllowedChildTypes
VersionId: 127
    LongTextProperties
        Parameters:         string level,        bool explicitOnly,        string member,        string[] includedTypes      
    DynamicProperties
        AppName:String: GetRelatedPermissions
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetRelatedPermissions
VersionId: 128
    DynamicProperties
        AppName:String: GetSharing
        RequiredPermissions:String: ________________________________________________*________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Sharing.SharingActions
        MethodName:String: GetSharing
VersionId: 129
    LongTextProperties
        Parameters: string skin, string category
    DynamicProperties
        AppName:String: GetTemplateScript
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.UI.HtmlTemplate
        MethodName:String: GetTemplateScript
VersionId: 130
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: HasPermission
        ActionTypeName:String: HasPermissionAction
        StyleHint:String: 
        RequiredPermissions:String: _________________________________________________*______________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 131
    LongTextProperties
        Parameters:         string username,      string password      
    DynamicProperties
        AppName:String: Login
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.Virtualization.AuthenticationHelper
        MethodName:String: Login
VersionId: 132
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: Logout
        Scenario:String: UserActions
        ActionTypeName:String: LogoutAction
        IncludeBackUrl:String: False
        CacheControl:String: Nondefined
        StoredIcon:String: logout
VersionId: 133
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: MoveTo
        Scenario:String: ListItem;ExploreActions;ManageViewsListItem
        ActionTypeName:String: MoveToAction
        StyleHint:String: 
        RequiredPermissions:String: _________________________________________________________**_____
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: move
VersionId: 134
    DynamicProperties
        AppName:String: Publish
        Scenario:String: ListItem;ExploreActions;SimpleApprovableListItem
        ActionTypeName:String: PublishAction
        RequiredPermissions:String: ________________________________________________________****___*
        CacheControl:String: Nondefined
        StoredIcon:String: publish
VersionId: 135
    LongTextProperties
        Parameters:      bool recursive,      SenseNet.ContentRepository.Search.Indexing.IndexRebuildLevel rebuildLevel      
    DynamicProperties
        AppName:String: RebuildIndex
        RequiredPermissions:String: _________________________________________________________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Content+Operations
        MethodName:String: RebuildIndex
VersionId: 136
    DynamicProperties
        AppName:String: RebuildIndexSubtree
        RequiredPermissions:String: _________________________________________________________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Content+Operations
        MethodName:String: RebuildIndexSubtree
VersionId: 137
    DynamicProperties
        AppName:String: RefreshIndexSubtree
        RequiredPermissions:String: _________________________________________________________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Content+Operations
        MethodName:String: RefreshIndexSubtree
VersionId: 138
    DynamicProperties
        AppName:String: Reject
        ActionTypeName:String: RejectAction
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 139
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: RemoveAllAspects
        ActionTypeName:String: RemoveAllAspectsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 140
    LongTextProperties
        Parameters:         string level,        string member,        string[] permissions      
    DynamicProperties
        AppName:String: GetRelatedItemsOneLevel
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetRelatedItemsOneLevel
VersionId: 141
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: RemoveAllFields
        ActionTypeName:String: RemoveAllFieldsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 142
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: RemoveAspects
        ActionTypeName:String: RemoveAspectsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 143
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: RemoveFields
        ActionTypeName:String: RemoveFieldsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 144
    LongTextProperties
        Parameters:         string id      
    DynamicProperties
        AppName:String: RemoveSharing
        RequiredPermissions:String: ________________________________________________*________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Sharing.SharingActions
        MethodName:String: RemoveSharing
VersionId: 145
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: ResetRecentIndexingActivities
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: ResetRecentIndexingActivities
VersionId: 146
    DynamicProperties
        AppName:String: RestoreVersion
        ActionTypeName:String: RestoreVersionAction
        RequiredPermissions:String: ___________________________________________________*_____*______
        CacheControl:String: Nondefined
        StoredIcon:String: restoreversion
VersionId: 147
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: RetrieveFields
        ActionTypeName:String: RetrieveFieldsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 148
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: Rss
        Scenario:String: ListActions
        ActionTypeName:String: 
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: rss
VersionId: 149
    LongTextProperties
        Parameters:         string query,        string displayName,        string queryType      
    DynamicProperties
        AppName:String: SaveQuery
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.QueryBuilder
        MethodName:String: SaveQuery
VersionId: 150
    DynamicProperties
        AppName:String: SetPermissions
        Scenario:String: WorkspaceActions;ListItem;ExploreActions
        ActionTypeName:String: SetPermissionsAction
        RequiredPermissions:String: ________________________________________________**_________*____
        CacheControl:String: Nondefined
        StoredIcon:String: security
VersionId: 151
    LongTextProperties
        Parameters:         string token, SenseNet.ContentRepository.Sharing.SharingLevel level,         SenseNet.ContentRepository.Sharing.SharingMode mode, bool sendNotification      
    DynamicProperties
        AppName:String: Share
        RequiredPermissions:String: ________________________________________________*________*______
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Sharing.SharingActions
        MethodName:String: Share
VersionId: 152
    LongTextProperties
        Parameters: long fullSize, string fieldName
    DynamicProperties
        AppName:String: StartBlobUpload
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ApplicationModel.UploadAction
        MethodName:String: StartBlobUpload
VersionId: 153
    LongTextProperties
        Parameters: string name, string contentType, long fullSize, string fieldName
    DynamicProperties
        AppName:String: StartBlobUploadToParent
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ApplicationModel.UploadAction
        MethodName:String: StartBlobUploadToParent
VersionId: 154
    LongTextProperties
        Parameters:         string user      
    DynamicProperties
        AppName:String: TakeLockOver
        RequiredPermissions:String: _______________________________________________________*________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: TakeLockOver
VersionId: 155
    LongTextProperties
        Parameters: string[] contentTypes
    DynamicProperties
        AppName:String: RemoveAllowedChildTypes
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.GenericContent
        MethodName:String: RemoveAllowedChildTypes
VersionId: 156
    LongTextProperties
        Parameters:         string level,        bool explicitOnly,        string member,        string[] permissions,      
    DynamicProperties
        AppName:String: GetRelatedItems
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetRelatedItems
VersionId: 157
    LongTextProperties
        Parameters:         string level,        string kind,        string[] permissions      
    DynamicProperties
        AppName:String: GetRelatedIdentitiesByPermissions
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetRelatedIdentities
VersionId: 158
    LongTextProperties
        Parameters:         string level,        string kind      
    DynamicProperties
        AppName:String: GetRelatedIdentities
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetRelatedIdentities
VersionId: 159
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: AddAspects
        ActionTypeName:String: AddAspectsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 160
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: AddFields
        ActionTypeName:String: AddFieldsAction
        RequiredPermissions:String: ______________________________________________*_________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 161
    DynamicProperties
        AppName:String: Ancestors
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: Ancestors
VersionId: 162
    DynamicProperties
        AppName:String: Approve
        Scenario:String: ListItem;ExploreActions;SimpleApprovableListItem
        ActionTypeName:String: ApproveAction
        RequiredPermissions:String: _____________________________________________________*___***___*
        CacheControl:String: Nondefined
        StoredIcon:String: approve
VersionId: 163
    DynamicProperties
        AppName:String: CheckIn
        Scenario:String: ListItem;ExploreActions;SimpleApprovableListItem
        ActionTypeName:String: CheckInAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: checkin
VersionId: 164
    LongTextProperties
        Parameters:         bool recurse      
    DynamicProperties
        AppName:String: CheckIndexIntegrity
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Search.Indexing.IntegrityChecker
        MethodName:String: CheckIndexIntegrity
VersionId: 165
    DynamicProperties
        AppName:String: CheckOut
        Scenario:String: ListItem;ExploreActions
        ActionTypeName:String: CheckOutAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: checkout
VersionId: 166
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: CheckSecurityConsistency
        Scenario:String: 
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: CheckSecurityConsistency
VersionId: 167
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: CopyTo
        Scenario:String: ListItem;ExploreActions;ManageViewsListItem
        ActionTypeName:String: CopyToAction
        StyleHint:String: 
        RequiredPermissions:String: _________________________________________________________*______
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: copy
VersionId: 168
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: Delete
        Scenario:String: WorkspaceActions;ListItem;ExploreActions;ListActions;ManageViewsListItem;SimpleListItem;SimpleApprovableListItem;ReadOnlyListItem;DocumentDetails
        ActionTypeName:String: DeleteAction
        StyleHint:String: 
        RequiredPermissions:String: ____________________________________________________*___________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: delete
VersionId: 169
    LongTextProperties
        Parameters: SenseNet.TaskManagement.Core.SnTaskResult result
    DynamicProperties
        AppName:String: DocumentPreviewFinalizer
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: DocumentPreviewFinalizer
VersionId: 170
    LongTextProperties
        Parameters: string token, long fullSize, string fieldName, string fileName
    DynamicProperties
        AppName:String: FinalizeBlobUpload
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ApplicationModel.UploadAction
        MethodName:String: FinalizeBlobUpload
VersionId: 171
    DynamicProperties
        AppName:String: FinalizeContent
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ApplicationModel.UploadAction
        MethodName:String: FinalizeContent
VersionId: 172
    DynamicProperties
        AppName:String: ForceUndoCheckOut
        Scenario:String: ListItem;ExploreActions
        ActionTypeName:String: ForceUndoCheckOutAction
        RequiredPermissions:String: _______________________________________________________*_***___*
        CacheControl:String: Nondefined
        StoredIcon:String: undocheckout
VersionId: 173
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: GetAllContentTypes
        Scenario:String: 
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: GetListOfAllContentTypes
VersionId: 174
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: GetAllowedChildTypesFromCTD
        Scenario:String: 
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: GetAllowedChildTypesFromCTD
VersionId: 175
    LongTextProperties
        Description: 
        Parameters:         string[] permissions      
    DynamicProperties
        AppName:String: GetAllowedUsers
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetAllowedUsers
VersionId: 176
    LongTextProperties
        Parameters: string fieldName
    DynamicProperties
        AppName:String: GetBinaryToken
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ApplicationModel.UploadAction
        MethodName:String: GetBinaryToken
VersionId: 177
    LongTextProperties
        Parameters:         string identity      
    DynamicProperties
        AppName:String: GetChildrenPermissionInfo
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetChildrenPermissionInfo
VersionId: 178
    DynamicProperties
        AppName:String: GetExistingPreviewImages
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: GetExistingPreviewImagesForOData
VersionId: 179
    LongTextProperties
        Parameters:         string displayName      
    DynamicProperties
        AppName:String: GetNameFromDisplayName
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.ContentNamingProvider
        MethodName:String: GetNameFromDisplayName
VersionId: 180
    LongTextProperties
        Parameters:         string identity      
    DynamicProperties
        AppName:String: GetPermissionInfo
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetPermissionInfo
VersionId: 181
    LongTextProperties
        Parameters:         string identity      
    DynamicProperties
        AppName:String: GetPermissionOverview
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.PermissionQuery
        MethodName:String: GetPermissionOverview
VersionId: 182
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: GetPermissions
        ActionTypeName:String: GetPermissionsAction
        StyleHint:String: 
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
VersionId: 183
    DynamicProperties
        AppName:String: GetPreviewImages
        RequiredPermissions:String: ______________________________________________________________*_
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: GetPreviewImagesForOData
VersionId: 184
    LongTextProperties
        Parameters:         bool onlyPublic      
    DynamicProperties
        AppName:String: GetQueries
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.QueryBuilder
        MethodName:String: GetQueries
VersionId: 185
    LongTextProperties
        Parameters: 
    DynamicProperties
        AppName:String: GetQueryBuilderMetadata
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Portal.QueryBuilder
        MethodName:String: GetMetadata
VersionId: 186
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: GetRecentIndexingActivities
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: GetRecentIndexingActivities
VersionId: 187
    LongTextProperties
        Description: 
        Parameters: 
    DynamicProperties
        AppName:String: GetRecentSecurityActivities
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: GetRecentSecurityActivities
VersionId: 188
    LongTextProperties
        Description: 
        Parameters: string userOrGroup
    DynamicProperties
        AppName:String: TakeOwnership
        Scenario:String: 
        StyleHint:String: 
        RequiredPermissions:String: _____________________________________________*__________________
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        ClassName:String: SenseNet.ContentRepository.RepositoryTools
        MethodName:String: TakeOwnership
VersionId: 189
    DynamicProperties
        AppName:String: UndoCheckOut
        Scenario:String: ListItem;ExploreActions
        ActionTypeName:String: UndoCheckOutAction
        RequiredPermissions:String: _________________________________________________________***___*
        CacheControl:String: Nondefined
        StoredIcon:String: undocheckout
VersionId: 191
    LongTextProperties
        Parameters: int[] contentIds
    DynamicProperties
        AppName:String: AddMembers
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Group
        MethodName:String: AddMembers
VersionId: 192
    LongTextProperties
        Description: 
        Parameters:         bool directOnly      
    DynamicProperties
        AppName:String: GetParentGroups
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetParentGroups
VersionId: 193
    LongTextProperties
        Parameters: int[] contentIds
    DynamicProperties
        AppName:String: RemoveMembers
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Group
        MethodName:String: RemoveMembers
VersionId: 195
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: Thumbnail
        Scenario:String: 
        ActionTypeName:String: 
        StyleHint:String: 
        RequiredPermissions:String: ___________________________________________________________*___*
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: application
        Width:Int: 120
        Height:Int: 120
        ImageType:String: Binary
        ImageFieldName:String: Binary
        SmoothingMode:String: antialias
        InterpolationMode:String: highqualitybicubic
        PixelOffsetMode:String: highquality
        ResizeTypeMode:String: crop
        CropVAlign:String: Center
        CropHAlign:String: Center
VersionId: 197
    LongTextProperties
        Description: 
    DynamicProperties
        AppName:String: Browse
        Scenario:String: ListItem;ExploreToolbar
        ActionTypeName:String: OpenLinkAction
        StyleHint:String: 
        RequiredPermissions:String: ___________________________________________________________*___*
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        MaxAge:String: 
        CustomUrlParameters:String: 
        StoredIcon:String: link
VersionId: 199
    LongTextProperties
        Parameters: string contentTypeName
    DynamicProperties
        AppName:String: GetSchema
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Services.Metadata.ClientMetadataProvider
        MethodName:String: GetSchema
VersionId: 200
    LongTextProperties
        Parameters: 
    DynamicProperties
        AppName:String: GetVersionInfo
        IncludeBackUrl:String: Default
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Repository
        MethodName:String: GetVersionInfo
VersionId: 202
    DynamicProperties
        AppName:String: SetInitialPreviewProperties
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.Preview.DocumentPreviewProvider
        MethodName:String: SetInitialPreviewProperties
VersionId: 204
    LongTextProperties
        Parameters: string text
    DynamicProperties
        AppName:String: Decrypt
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.Cryptography.CryptoServiceProvider
        MethodName:String: Decrypt
VersionId: 205
    LongTextProperties
        Parameters: string text
    DynamicProperties
        AppName:String: Encrypt
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.Cryptography.CryptoServiceProvider
        MethodName:String: Encrypt
VersionId: 207
    LongTextProperties
        Description: 
        Parameters:         bool directOnly      
    DynamicProperties
        AppName:String: GetParentGroups
        CacheControl:String: Nondefined
        ClassName:String: SenseNet.ContentRepository.Security.PermissionQueryForRest
        MethodName:String: GetParentGroups
VersionId: 208
    LongTextProperties
        Description: 
        Parameters: string back
    DynamicProperties
        AppName:String: Profile
        Scenario:String: UserActions
        CacheControl:String: Nondefined
        StoredIcon:String: userprofile
        ClassName:String: SenseNet.Services.IdentityTools
        MethodName:String: BrowseProfile
VersionId: 209
    BinaryProperties
        Binary: #88, F88, 0L, Admin.png, image/png, /Root/IMS/BuiltIn/Portal/Admin/Admin.png
    DynamicProperties
        PageCount:Int: -4
        Width:Int: 32
        Height:Int: 32
VersionId: 210
    LongTextProperties
        Description: 
    DynamicProperties
        SyncGuid:String: 
        Members:Reference: [11,1200,1198]
VersionId: 211
    LongTextProperties
        Description: 
VersionId: 212
    LongTextProperties
        Description: 
    DynamicProperties
        SyncGuid:String: 
        Members:Reference: [7]
VersionId: 213
    LongTextProperties
        Description: 
VersionId: 214
    LongTextProperties
        Description: 
    DynamicProperties
        SyncGuid:String: 
        Members:Reference: [7]
VersionId: 215
    LongTextProperties
        Description: 
VersionId: 216
    LongTextProperties
        Description: 
    DynamicProperties
        SyncGuid:String: 
        Members:Reference: [1197,1202,11,1200,1198]
VersionId: 217
    LongTextProperties
        Description: 
    DynamicProperties
        SyncGuid:String: 
VersionId: 218
    LongTextProperties
        OldPasswords: <?xml version=""1.0"" encoding=""utf-16""?>  <ArrayOfOldPasswordData xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" />
    DynamicProperties
        Domain:String: BuiltIn
        FullName:String: VirtualADUser
        LoginName:String: VirtualADUser
VersionId: 219
    DynamicProperties
        Hidden:Int: 1
VersionId: 236
    BinaryProperties
        Binary: #103, F103, 15642L, Global.html, text/html, /Root/System/ErrorMessages/Default/Global.html
    DynamicProperties
        PageCount:Int: -4
VersionId: 237
    BinaryProperties
        Binary: #104, F104, 15125L, UserGlobal.html, text/html, /Root/System/ErrorMessages/Default/UserGlobal.html
    DynamicProperties
        PageCount:Int: -4
VersionId: 238
    LongTextProperties
        AllowedChildTypes: GetMetadataApplication SystemFolder Folder
VersionId: 239
    LongTextProperties
        AllowedChildTypes: GetMetadataApplication SystemFolder Folder
VersionId: 240
    DynamicProperties
        AppName:String: complextypes
        CacheControl:String: Nondefined
VersionId: 241
    DynamicProperties
        AppName:String: contenttypes
        CacheControl:String: Nondefined
VersionId: 242
    DynamicProperties
        AppName:String: enums
        CacheControl:String: Nondefined
VersionId: 243
    DynamicProperties
        AppName:String: fieldsettings
        CacheControl:String: Nondefined
VersionId: 244
    DynamicProperties
        AppName:String: meta
        CacheControl:String: Nondefined
VersionId: 245
    DynamicProperties
        AppName:String: resources
        CacheControl:String: Nondefined
VersionId: 246
    DynamicProperties
        AppName:String: schemas
        CacheControl:String: Nondefined
VersionId: 248
    BinaryProperties
        Binary: #105, F105, 83L, binaryhandler.ashx, application/octet-stream, /Root/System/WebRoot/binaryhandler.ashx
    DynamicProperties
        PageCount:Int: -4
VersionId: 250
    BinaryProperties
        Binary: #106, F106, 75L, Dws.asmx, application/octet-stream, /Root/System/WebRoot/DWS/Dws.asmx
    DynamicProperties
        PageCount:Int: -4
VersionId: 251
    BinaryProperties
        Binary: #107, F107, 75L, Fpp.ashx, application/octet-stream, /Root/System/WebRoot/DWS/Fpp.ashx
    DynamicProperties
        PageCount:Int: -4
VersionId: 252
    BinaryProperties
        Binary: #108, F108, 77L, Lists.asmx, application/octet-stream, /Root/System/WebRoot/DWS/Lists.asmx
    DynamicProperties
        PageCount:Int: -4
VersionId: 253
    BinaryProperties
        Binary: #109, F109, 9520L, owssvr.aspx, text/asp, /Root/System/WebRoot/DWS/owssvr.aspx
    DynamicProperties
        PageCount:Int: -4
VersionId: 254
    BinaryProperties
        Binary: #110, F110, 80L, Versions.asmx, application/octet-stream, /Root/System/WebRoot/DWS/Versions.asmx
    DynamicProperties
        PageCount:Int: -4
VersionId: 255
    BinaryProperties
        Binary: #111, F111, 76L, Webs.asmx, application/octet-stream, /Root/System/WebRoot/DWS/Webs.asmx
    DynamicProperties
        PageCount:Int: -4
VersionId: 256
    BinaryProperties
        Binary: #112, F112, 90L, vsshandler.ashx, application/octet-stream, /Root/System/WebRoot/vsshandler.ashx
    LongTextProperties
        Description: Http handler for serving Lucene index file paths. This content can be invoked only from the local machine.
    DynamicProperties
        PageCount:Int: -4
VersionId: 257
    DynamicProperties
        TrashDisabled:Int: 1
        IsActive:Int: 1
        BagCapacity:Int: 100
VersionId: 258
    DynamicProperties
        Hidden:Int: 1
VersionId: 260
    DynamicProperties
        AppName:String: Restore
        Scenario:String: ListItem;ExploreToolbar
        ActionTypeName:String: RestoreAction
        RequiredPermissions:String: _________________________________________________________*______
        CacheControl:String: Nondefined
        StoredIcon:String: restore
";

        public IDictionary<string, string> ContentTypeDefinitions => new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
        {
			#region  1. Application
			{ "Application", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Application"" parentType=""GenericContent"" handler=""SenseNet.ApplicationModel.Application"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Application,DisplayName</DisplayName>
  <Description>$Ctd-Application,Description</Description>
  <Icon>Application</Icon>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""AppName"" type=""ShortText"">
      <DisplayName>$Ctd-Application,AppName-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Scenario"" type=""ShortText"">
      <DisplayName>$Ctd-Application,Scenario-DisplayName</DisplayName>
      <Description>$Ctd-Application,Scenario-Description</Description>
    </Field>
    <Field name=""ActionTypeName"" type=""ShortText"">
      <DisplayName>$Ctd-Application,ActionTypeName-DisplayName</DisplayName>
      <Description>$Ctd-Application,ActionTypeName-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsModal"" type=""Boolean"">
      <DisplayName>$Ctd-Application,ModalAction-DisplayName</DisplayName>
      <Description>$Ctd-Application,ModalAction-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Disabled"" type=""Boolean"">
      <DisplayName>$Ctd-Application,Disabled-DisplayName</DisplayName>
      <Description>$Ctd-Application,Disabled-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Clear"" type=""Boolean"">
      <DisplayName>$Ctd-Application,Clear-DisplayName</DisplayName>
      <Description>$Ctd-Application,Clear-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Icon"" type=""ShortText"">
      <DisplayName>$Ctd-Application,IconIdentifier-DisplayName</DisplayName>
      <Description>$Ctd-Application,IconIdentifier-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <ReadOnly>false</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""StyleHint"" type=""ShortText"">
      <DisplayName>$Ctd-Application,StyleHint-DisplayName</DisplayName>
      <Description>$Ctd-Application,StyleHint-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""RequiredPermissions"" type=""PermissionChoice"">
      <DisplayName>$Ctd-Application,RequiredPermissions-DisplayName</DisplayName>
      <Description>$Ctd-Application,RequiredPermissions-Description</Description>
      <Configuration>
        <AllowMultiple>true</AllowMultiple>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <VisiblePermissionCount>19</VisiblePermissionCount>
      </Configuration>
    </Field>
    <Field name=""DeepPermissionCheck"" type=""Boolean"">
      <DisplayName>$Ctd-Application,DeepPermissionCheck-DisplayName</DisplayName>
      <Description>$Ctd-Application,DeepPermissionCheck-Description</Description>
      <Configuration>
        <DefaultValue>false</DefaultValue>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IncludeBackUrl"" type=""Choice"">
      <DisplayName>$Ctd-Application,IncludeBackUrl-DisplayName</DisplayName>
      <Description>$Ctd-Application,IncludeBackUrl-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Enum type=""SenseNet.ApplicationModel.IncludeBackUrlMode""/>
        </Options>
      </Configuration>
    </Field>
    <Field name=""CacheControl"" type=""Choice"">
      <DisplayName>$Ctd-Application,CacheControl-DisplayName</DisplayName>
      <Description>$Ctd-Application,CacheControl-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""Nondefined"">$Ctd-Application,CacheControl-Nondefined</Option>
          <Option value=""NoCache"">$Ctd-Application,CacheControl-NoCache</Option>
          <Option value=""Private"">$Ctd-Application,CacheControl-Private</Option>
          <Option value=""Public"">$Ctd-Application,CacheControl-Public</Option>
          <Option value=""Server"">$Ctd-Application,CacheControl-Server</Option>
          <Option value=""ServerAndNoCache"">$Ctd-Application,CacheControl-ServerAndNoCache</Option>
          <Option value=""ServerAndPrivate"">$Ctd-Application,CacheControl-ServerAndPrivate</Option>
        </Options>
        <DefaultValue>Nondefined</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""MaxAge"" type=""ShortText"">
      <DisplayName>$Ctd-Application,MaxAge-DisplayName</DisplayName>
      <Description>$Ctd-Application,MaxAge-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""CustomUrlParameters"" type=""ShortText"">
      <DisplayName>$Ctd-Application,CustomUrlParameters-DisplayName</DisplayName>
      <Description>$Ctd-Application,CustomUrlParameters-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  2. ApplicationOverride
			{ "ApplicationOverride", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ApplicationOverride"" parentType=""Application"" handler=""SenseNet.ApplicationModel.Application"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ApplicationOverride,DisplayName</DisplayName>
  <Description>$Ctd-ApplicationOverride,Description</Description>
  <Icon>Application</Icon>
</ContentType>
" },
			#endregion
			#region  3. Aspect
			{ "Aspect", @"<ContentType name=""Aspect"" parentType=""ContentList"" handler=""SenseNet.ContentRepository.Aspect"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Aspect,DisplayName</DisplayName>
  <Description>$Ctd-Aspect,Description</Description>
  <Icon>Aspect</Icon>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Aspect,DisplayName-DisplayName</DisplayName>
    </Field>
    <Field name=""AspectDefinition"" type=""LongText"">
      <DisplayName>$Ctd-Aspect,AspectDefinition-DisplayName</DisplayName>
      <Description>$Ctd-Aspect,AspectDefinition-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DefaultView"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,DefaultView-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,DefaultView-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""AvailableViews"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,AvailableViews-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,AvailableViews-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>ListView</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""FieldSettingContents"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,FieldSettingContents-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>FieldSettingContent</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""AvailableContentTypeFields"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,AvailableContentTypeFields-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>FieldSettingContent</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <!-- Exchange integration -->
    <Field name=""ListEmail"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,ListEmail-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,ListEmail-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ExchangeSubscriptionId"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,ExchangeSubscriptionId-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,ExchangeSubscriptionId-Descriptione</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""OverwriteFiles"" type=""Boolean"">
      <DisplayName>$Ctd-ContentList,OverwriteFiles-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,OverwriteFiles-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""GroupAttachments"" type=""Choice"">
      <DisplayName>$Ctd-ContentList,GroupAttachments-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,GroupAttachments-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""email"" selected=""true"">$Ctd-ContentList,GroupAttachments-email</Option>
          <Option value=""root"">$Ctd-ContentList,GroupAttachments-root</Option>
          <Option value=""subject"">$Ctd-ContentList,GroupAttachments-subject</Option>
          <Option value=""sender"">$Ctd-ContentList,GroupAttachments-sender</Option>
        </Options>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SaveOriginalEmail"" type=""Boolean"">
      <DisplayName>$Ctd-ContentList,SaveOriginalEmail-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,SaveOriginalEmail-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IncomingEmailWorkflow"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,IncomingEmailWorkflow-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,IncomingEmailWorkflow-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <SelectionRoot>
          <Path>/Root/System/Schema/ContentTypes/GenericContent/Workflow/MailProcessorWorkflow</Path>
        </SelectionRoot>
        <DefaultValue>/Root/System/Schema/ContentTypes/GenericContent/Workflow/MailProcessorWorkflow</DefaultValue>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <!-- Exchange integration end -->
    <Field name=""AllowedChildTypes"" type=""AllowedChildTypes"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  4. BinaryFieldSetting
			{ "BinaryFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name='BinaryFieldSetting' parentType='FieldSettingContent' handler='SenseNet.ContentRepository.Schema.FieldSettingContent' xmlns='http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition'>
  <DisplayName>$Ctd-BinaryFieldSetting,DisplayName</DisplayName>
  <Icon>File</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  5. ChoiceFieldSetting
			{ "ChoiceFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name='ChoiceFieldSetting' parentType='ShortTextFieldSetting' handler='SenseNet.ContentRepository.Schema.FieldSettingContent' xmlns='http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition'>
  <DisplayName>$Ctd-ChoiceFieldSetting,DisplayName</DisplayName>
  <Icon>addchoicefield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  6. ContentLink
			{ "ContentLink", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ContentLink"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.ContentLink"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ContentLink,DisplayName</DisplayName>
	<Description>$Ctd-ContentLink,Description</Description>
	<Icon>Folder</Icon>
	<Fields>
    <Field name=""Link"" type=""Reference"">
      <DisplayName>$Ctd-ContentLink,Link-DisplayName</DisplayName>
      <Description>$Ctd-ContentLink,Link-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  7. ContentList
			{ "ContentList", @"<ContentType name=""ContentList"" parentType=""Folder"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ContentList,DisplayName</DisplayName>
  <Description>$Ctd-ContentList,Description</Description>
  <Icon>ContentList</Icon>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,DisplayName-DisplayName</DisplayName>
    </Field>
    <Field name=""ContentListDefinition"" type=""LongText"">
      <DisplayName>$Ctd-ContentList,ContentListDefinition-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,ContentListDefinition-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DefaultView"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,DefaultView-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,DefaultView-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""AvailableViews"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,AvailableViews-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,AvailableViews-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>ListView</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""FieldSettingContents"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,FieldSettingContents-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>FieldSettingContent</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""AvailableContentTypeFields"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,AvailableContentTypeFields-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>FieldSettingContent</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <!-- Exchange integration -->
    <Field name=""ListEmail"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,ListEmail-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,ListEmail-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ExchangeSubscriptionId"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,ExchangeSubscriptionId-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,ExchangeSubscriptionId-Descriptione</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""OverwriteFiles"" type=""Boolean"">
      <DisplayName>$Ctd-ContentList,OverwriteFiles-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,OverwriteFiles-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""GroupAttachments"" type=""Choice"">
      <DisplayName>$Ctd-ContentList,GroupAttachments-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,GroupAttachments-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""email"" selected=""true"">$Ctd-ContentList,GroupAttachments-email</Option>
          <Option value=""root"">$Ctd-ContentList,GroupAttachments-root</Option>
          <Option value=""subject"">$Ctd-ContentList,GroupAttachments-subject</Option>
          <Option value=""sender"">$Ctd-ContentList,GroupAttachments-sender</Option>
        </Options>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SaveOriginalEmail"" type=""Boolean"">
      <DisplayName>$Ctd-ContentList,SaveOriginalEmail-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,SaveOriginalEmail-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IncomingEmailWorkflow"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,IncomingEmailWorkflow-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,IncomingEmailWorkflow-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <SelectionRoot>
          <Path>/Root/System/Schema/ContentTypes/GenericContent/Workflow/MailProcessorWorkflow</Path>
        </SelectionRoot>
        <DefaultValue>/Root/System/Schema/ContentTypes/GenericContent/Workflow/MailProcessorWorkflow</DefaultValue>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""OnlyFromLocalGroups"" type=""Boolean"">
      <DisplayName>$Ctd-ContentList,OnlyFromLocalGroups-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,OnlyFromLocalGroups-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InboxFolder"" type=""ShortText"">
      <DisplayName>$Ctd-ContentList,InboxFolder-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,InboxFolder-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <!-- Exchange integration end -->
    <Field name=""AllowedChildTypes"" type=""AllowedChildTypes"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""OwnerWhenVisitor"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,OwnerWhenVisitor-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,OwnerWhenVisitor-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
        </SelectionRoot>
        <DefaultValue>/Root/IMS/BuiltIn/Portal/Admin</DefaultValue>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  8. ContentType
			{ "ContentType", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ContentType"" handler=""SenseNet.ContentRepository.Schema.ContentType"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ContentType,DisplayName</DisplayName>
	<Description>$Ctd-ContentType,Description</Description>
	<Icon>ContentType</Icon>
	<Fields>
    <Field name=""Id"" type=""Integer"">
      <DisplayName>$Ctd-ContentType,Id-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,Id-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ParentId"" type=""Integer"">
      <DisplayName>$Ctd-ContentType,ParentId-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,ParentId-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""VersionId"" type=""Integer"">
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Type"" type=""NodeType"">
      <DisplayName>$Ctd-ContentType,Type-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,Type-Description</Description>
      <Bind property=""NodeType"" />
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.ExclusiveTypeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""TypeIs"" type=""NodeType"">
      <DisplayName>$Ctd-ContentType,TypeIs-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,TypeIs-Description</Description>
      <Bind property=""NodeType"" />
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.TypeTreeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Name"" type=""ShortText"">
      <DisplayName>$Ctd-ContentType,Name-DisplayName</DisplayName>
      <Indexing>
        <Store>Yes</Store>
        <Analyzer>Keyword</Analyzer>
      </Indexing>
      <Configuration>
        <Compulsory>true</Compulsory>
      </Configuration>
    </Field>
    <Field name=""CreatedById"" type=""Integer"">
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ModifiedById"" type=""Integer"">
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <DisplayName>$Ctd-ContentType,Version-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,Version-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>

    <Field name=""Path"" type=""ShortText"">
			<DisplayName>$Ctd-ContentType,Path-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,Path-Description</Description>
			<Configuration>
				<ReadOnly>true</ReadOnly>
			</Configuration>
		</Field>
    <Field name=""Depth"" type=""Integer"">
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""InTree"" type=""ShortText"">
      <Bind property=""Path""/>
      <Indexing>
        <Analyzer>Keyword</Analyzer>
        <IndexHandler>SenseNet.Search.Indexing.InTreeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""InFolder"" type=""ShortText"">
      <Bind property=""Path""/>
      <Indexing>
        <Analyzer>Keyword</Analyzer>
        <IndexHandler>SenseNet.Search.Indexing.InFolderIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""IsSystemContent"" type=""Boolean"">
      <DisplayName>$Ctd-ContentType,IsSystemContent-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,IsSystemContent-Description</Description>
      <Bind property=""IsSystem""></Bind>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>

    <Field name=""HandlerName"" type=""ShortText"">
			<DisplayName>$Ctd-ContentType,HandlerName-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,HandlerName-Description</Description>
		</Field>
		<Field name=""ParentTypeName"" type=""ShortText"">
			<DisplayName>$Ctd-ContentType,ParentTypeName-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,ParentTypeName-Description</Description>
		</Field>
		<Field name=""DisplayName"" type=""ShortText"">
			<DisplayName>$Ctd-ContentType,DisplayName-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,DisplayName-Description</Description>
		</Field>
		<Field name=""Description"" type=""LongText"">
			<DisplayName>$Ctd-ContentType,Description-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,Description-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
    </Field>
		<Field name=""Icon"" type=""ShortText"">
			<DisplayName>$Ctd-ContentType,Icon-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,Icon-Description</Description>
		</Field>
		<Field name=""Binary"" type=""Binary"">
			<DisplayName>$Ctd-ContentType,Binary-DisplayName</DisplayName>
			<Description>$Ctd-ContentType,Binary-Description</Description>
			<Configuration>
        <IsText>true</IsText>
        <DefaultValue>
          <![CDATA[<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""MyType"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.GenericContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>MyType</DisplayName>
  <Description></Description>
  <Icon>Content</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <AllowedChildTypes>ContentTypeName1,ContentTypeName2</AllowedChildTypes>
  <Fields>
    <Field name=""ShortTextField"" type=""ShortText"">
      <DisplayName>ShortTextField</DisplayName>
      <Description></Description>
      <Configuration>
        <MaxLength>100</MaxLength>
        <MinLength>0</MinLength>
        <Regex>[a-zA-Z0-9]*$</Regex>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LongTextField"" type=""LongText"">
      <DisplayName>LongTextField</DisplayName>
      <Description></Description>
      <Configuration>
        <MaxLength>100</MaxLength>
        <MinLength>0</MinLength>
        <TextType>LongText|RichText|AdvancedRichText</TextType>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""NumberField"" type=""Number"">
      <DisplayName>NumberField</DisplayName>
      <Description></Description>
      <Configuration>
        <MinValue>0</MinValue>
        <MaxValue>100.5</MaxValue>
        <Digits>2</Digits>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IntegerField"" type=""Integer"">
      <DisplayName>IntegerField</DisplayName>
      <Description></Description>
      <Configuration>
        <MinValue>0</MinValue>
        <MaxValue>100</MaxValue>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""BooleanField"" type=""Boolean"">
      <DisplayName>BooleanField</DisplayName>
      <Description></Description>
      <Configuration>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ChoiceField"" type=""Choice"">
      <DisplayName>ChoiceField</DisplayName>
      <Description></Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option selected=""true"">1</Option>
          <Option>2</Option>
        </Options>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DateTimeField"" type=""DateTime"">
      <DisplayName>DateTimeField</DisplayName>
      <Description></Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <Precision>Second</Precision>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ReferenceField"" type=""Reference"">
      <DisplayName>ReferenceField</DisplayName>
      <Description></Description>
      <Configuration>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>Type1</Type>
          <Type>Type2</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/Path1</Path>
          <Path>/Root/Path2</Path>
        </SelectionRoot>
        <DefaultValue>/Root/Path1,/Root/Path2</DefaultValue>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""BinaryField"" type=""Binary"">
      <DisplayName>BinaryField</DisplayName>
      <Description></Description>
      <Configuration>
        <IsText>true</IsText>
        <ReadOnly>false</ReadOnly>
        <Compulsory>false</Compulsory>
        <DefaultValue></DefaultValue>
        <VisibleBrowse>Show|Hide|Advanced</VisibleBrowse>
        <VisibleEdit>Show|Hide|Advanced</VisibleEdit>
        <VisibleNew>Show|Hide|Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>]]>
        </DefaultValue>
      </Configuration>
		</Field>
    <Field name=""CreatedBy"" type=""Reference"">
      <DisplayName>$Ctd-ContentType,CreatedBy-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,CreatedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""CreationDate"" type=""DateTime"">
      <DisplayName>$Ctd-ContentType,CreationDate-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,CreationDate-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ModifiedBy"" type=""Reference"">
      <DisplayName>$Ctd-ContentType,ModifiedBy-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,ModifiedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ModificationDate"" type=""DateTime"">
      <DisplayName>$Ctd-ContentType,ModificationDate-DisplayName</DisplayName>
      <Description>$Ctd-ContentType,ModificationDate-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""EnableLifespan"" type=""Boolean"">
      <DisplayName>$Ctd-ContentType,EnableLifespan-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""AllFieldSettingContents"" type=""Reference"">
      <DisplayName>$Ctd-ContentType,AllFieldSettingContents-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>FieldSettingContent</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
	</Fields>
</ContentType>
" },
			#endregion
			#region  9. CurrencyFieldSetting
			{ "CurrencyFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""CurrencyFieldSetting"" parentType=""NumberFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-CurrencyFieldSetting,DisplayName</DisplayName>
  <Icon>addcurrencyfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  10. CustomList
			{ "CustomList", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""CustomList"" parentType=""ItemList"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-CustomList,DisplayName</DisplayName>
  <Description>$Ctd-CustomList,Description</Description>
  <Icon>ContentList</Icon>
  <AllowedChildTypes>
    ListItem
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  11. CustomListItem
			{ "CustomListItem", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""CustomListItem"" parentType=""ListItem"" handler=""SenseNet.ContentRepository.GenericContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-CustomListItem,DisplayName</DisplayName>
  <Description>$Ctd-CustomListItem,Description</Description>
  <Icon>FormItem</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <Fields>
    <Field name=""WorkflowsRunning"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModifiedBy"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModificationDate"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  12. DateTimeFieldSetting
			{ "DateTimeFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""DateTimeFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-DateTimeFieldSetting,DisplayName</DisplayName>
  <Icon>adddatetimefield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  13. Device
			{ "Device", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Device"" parentType=""Folder"" handler=""SenseNet.ApplicationModel.Device"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Device,DisplayName</DisplayName>
  <Description>$Ctd-Device,Description</Description>
  <Icon>Device</Icon>
  <Fields>
    <Field name=""UserAgentPattern"" type=""ShortText"">
      <DisplayName>$Ctd-Device,UserAgentPattern-DisplayName</DisplayName>
      <Description>$Ctd-Device,UserAgentPattern-Description</Description>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  14. DocumentLibrary
			{ "DocumentLibrary", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""DocumentLibrary"" parentType=""Library"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-DocumentLibrary,DisplayName</DisplayName>
  <Description>$Ctd-DocumentLibrary,Description</Description>
  <Icon>ContentList</Icon>
  <AllowedChildTypes>
    Folder,File
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  15. Domain
			{ "Domain", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Domain"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Domain"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Domain,DisplayName</DisplayName>
  <Description>$Ctd-Domain,Description</Description>
  <Icon>Domain</Icon>
  <AllowedChildTypes>
    User,RegisteredUser,Group,OrganizationalUnit,ADFolder
  </AllowedChildTypes>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Domain,DisplayName-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SyncGuid"" type=""ShortText"">
      <DisplayName>$Ctd-Domain,SyncGuid-DisplayName</DisplayName>
      <Description>$Ctd-Domain,SyncGuid-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LastSync"" type=""DateTime"">
      <DisplayName>$Ctd-Domain,LastSync-DisplayName</DisplayName>
      <Description>$Ctd-Domain,LastSync-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  16. Domains
			{ "Domains", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Domains"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Domains,DisplayName</DisplayName>
  <Description>$Ctd-Domains,Description</Description>
  <Icon>Folder</Icon>
  <AllowedChildTypes>
    Domain
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  17. DynamicJsonContent
			{ "DynamicJsonContent", @"<ContentType name=""DynamicJsonContent"" parentType=""File"" handler=""SenseNet.Portal.Handlers.DynamicJsonContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>Dynamic JSON content</DisplayName>
  <Description></Description>
  <Icon>Settings</Icon>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  18. Email
			{ "Email", @"<ContentType name=""Email"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Email,DisplayName</DisplayName>
  <Description>$Ctd-Email,Description</Description>
  <Icon>Document</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <AllowedChildTypes>
    File
  </AllowedChildTypes>
  <Fields>
    <Field name=""From"" type=""ShortText"">
      <DisplayName>$Ctd-Email,From-DisplayName</DisplayName>
      <Description>$Ctd-Email,From-Description</Description>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Email,DisplayName-DisplayName</DisplayName>
      <Description>$Ctd-Email,DisplayName-Description</Description>
    </Field>
    <Field name=""Body"" type=""LongText"">
      <DisplayName>$Ctd-Email,Body-DisplayName</DisplayName>
      <Description>$Ctd-Email,Body-Description</Description>
      <Configuration>
        <ControlHint>sn:RichText</ControlHint>
        <TextType>RichText</TextType>
      </Configuration>
    </Field>
    <Field name=""Sent"" type=""DateTime"">
      <DisplayName>$Ctd-Email,Sent-DisplayName</DisplayName>
      <Description>$Ctd-Email,Sent-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  19. ExecutableFile
			{ "ExecutableFile", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ExecutableFile"" parentType=""File"" handler=""SenseNet.ContentRepository.File"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ExecutableFile,DisplayName</DisplayName>
  <Description>$Ctd-ExecutableFile,Description</Description>
  <Icon>Application</Icon>
  <Preview>false</Preview>
</ContentType>" },
			#endregion
			#region  20. ExportToCsvApplication
			{ "ExportToCsvApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ExportToCsvApplication"" parentType=""Application"" handler=""SenseNet.Services.ExportToCsvApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ExportToCsvApplication,DisplayName</DisplayName>
  <Description>$Ctd-ExportToCsvApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  21. FieldSettingContent
			{ "FieldSettingContent", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""FieldSettingContent"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-FieldSettingContent,DisplayName</DisplayName>
  <Description>$Ctd-FieldSettingContent,Description</Description>
  <Icon>fieldsetting</Icon>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <Compulsory>true</Compulsory>
      </Configuration>
    </Field>
    <Field name=""Name"" type=""ShortText"">
      <Description>$Ctd-FieldSettingContent,Name-Description</Description>
      <Configuration>
        <ControlHint>sn:ShortText</ControlHint>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  22. File
			{ "File", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""File"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.File"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-File,DisplayName</DisplayName>
  <Description>$Ctd-File,Description</Description>
  <Icon>File</Icon>
  <Preview>true</Preview>
  <Fields>
    <Field name=""Binary"" type=""Binary"">
      <DisplayName>$Ctd-File,Binary-DisplayName</DisplayName>
      <Description>$Ctd-File,Binary-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModifiedBy"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModificationDate"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Locked"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Size"" type=""Number"">
      <DisplayName>$Ctd-File,Size-DisplayName</DisplayName>
      <Description>$Ctd-File,Size-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""FullSize"" type=""Number"">
      <DisplayName>$Ctd-File,FullSize-DisplayName</DisplayName>
      <Description>$Ctd-File,FullSize-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""PageCount"" type=""Integer"">
      <DisplayName>$Ctd-File,PageCount-DisplayName</DisplayName>
      <Description>$Ctd-File,PageCount-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DefaultValue>-4</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""MimeType"" type=""ShortText"">
      <DisplayName>$Ctd-File,MimeType-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Shapes"" type=""LongText"">
      <DisplayName>$Ctd-File,Shapes-DisplayName</DisplayName>
      <Description>$Ctd-File,Shapes-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""PageAttributes"" type=""LongText"">
      <DisplayName>$Ctd-File,PageAttributes-DisplayName</DisplayName>
      <Description>$Ctd-File,PageAttributes-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Watermark"" type=""ShortText"">
      <DisplayName>$Ctd-File,Watermark-DisplayName</DisplayName>
      <Description>$Ctd-File,Watermark-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  23. Folder
			{ "Folder", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Folder"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Folder,DisplayName</DisplayName>
  <Description>$Ctd-Folder,Description</Description>
  <Icon>Folder</Icon>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Folder,DisplayName-DisplayName</DisplayName>
      <Description>$Ctd-Folder,DisplayName-Description</Description>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  24. GenericContent
			{ "GenericContent", @"<ContentType name=""GenericContent"" handler=""SenseNet.ContentRepository.GenericContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-GenericContent,DisplayName</DisplayName>
  <Description>$Ctd-GenericContent,Description</Description>
  <Icon>Content</Icon>
  <Fields>
    <Field name=""Id"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,Id-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Id-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ParentId"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,ParentId-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ParentId-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""OwnerId"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,OwnerId-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,OwnerId-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Owner"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,Owner-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Owner-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""VersionId"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,VersionId-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersionId-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Type"" type=""NodeType"">
      <DisplayName>$Ctd-GenericContent,Type-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Type-Description</Description>
      <Bind property=""NodeType""></Bind>
      <Indexing>
        <Store>Yes</Store>
        <IndexHandler>SenseNet.Search.Indexing.ExclusiveTypeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""TypeIs"" type=""NodeType"">
      <DisplayName>$Ctd-GenericContent,TypeIs-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,TypeIs-Description</Description>
      <Bind property=""NodeType""></Bind>
      <Indexing>
        <Store>No</Store>
        <IndexHandler>SenseNet.Search.Indexing.TypeTreeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Icon"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,Icon-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Icon-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Name"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,Name-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Name-Description</Description>
      <Indexing>
        <Store>Yes</Store>
        <Analyzer>Keyword</Analyzer>
      </Indexing>
      <Configuration>
        <Compulsory>true</Compulsory>
        <ControlHint>sn:Name</ControlHint>
      </Configuration>
    </Field>
    <Field name=""CreatedById"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,CreatedById-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,CreatedById-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""ModifiedById"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,ModifiedById-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ModifiedById-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <DisplayName>$Ctd-GenericContent,Version-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Version-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Path"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,Path-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Path-Description</Description>
      <Indexing>
        <Store>Yes</Store>
        <Analyzer>Keyword</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Depth"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,Depth-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Depth-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""InTree"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,InTree-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,InTree-Description</Description>
      <Bind property=""Path""></Bind>
      <Indexing>
        <Analyzer>Keyword</Analyzer>
        <IndexHandler>SenseNet.Search.Indexing.InTreeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""InFolder"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,InFolder-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,InFolder-Description</Description>
      <Bind property=""Path""></Bind>
      <Indexing>
        <Analyzer>Keyword</Analyzer>
        <IndexHandler>SenseNet.Search.Indexing.InFolderIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""IsSystemContent"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,IsSystemContent-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,IsSystemContent-Description</Description>
      <Bind property=""IsSystem""></Bind>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""IsFolder"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,IsFolder-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,IsFolder-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,DisplayName-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,DisplayName-Description</Description>
      <Configuration>
        <ControlHint>sn:DisplayName</ControlHint>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <DisplayName>$Ctd-GenericContent,Description-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Description-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <ControlHint>sn:RichText</ControlHint>
      </Configuration>
    </Field>
    <Field name=""Hidden"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,Hidden-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Hidden-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,Index-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Index-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""EnableLifespan"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,EnableLifespan-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,EnableLifespan-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ValidFrom"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,ValidFrom-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ValidFrom-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ValidTill"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,ValidTill-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ValidTill-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""AllowedChildTypes"" type=""AllowedChildTypes"">
      <DisplayName>$Ctd-GenericContent,AllowedChildTypes-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,AllowedChildTypes-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""EffectiveAllowedChildTypes"" type=""AllowedChildTypes"">
      <DisplayName>$Ctd-GenericContent,EffectiveAllowedChildTypes-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,EffectiveAllowedChildTypes-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""VersioningMode"" type=""VersioningMode"">
      <DisplayName>$Ctd-GenericContent,VersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,VersioningMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,VersioningMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,VersioningMode-2</Option>
          <Option value=""3"">$Ctd-GenericContent,VersioningMode-3</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <DisplayName>$Ctd-GenericContent,InheritableVersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,InheritableVersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <ControlHint>sn:VersioningModeChoice</ControlHint>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,InheritableVersioningMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,InheritableVersioningMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,InheritableVersioningMode-2</Option>
          <Option value=""3"">$Ctd-GenericContent,InheritableVersioningMode-3</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""CreatedBy"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,CreatedBy-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,CreatedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""VersionCreatedBy"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,VersionCreatedBy-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersionCreatedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""CreationDate"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,CreationDate-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,CreationDate-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""VersionCreationDate"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,VersionCreationDate-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersionCreationDate-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModifiedBy"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,ModifiedBy-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ModifiedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""VersionModifiedBy"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,VersionModifiedBy-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersionModifiedBy-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModificationDate"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,ModificationDate-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ModificationDate-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""VersionModificationDate"" type=""DateTime"">
      <DisplayName>$Ctd-GenericContent,VersionModificationDate-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,VersionModificationDate-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""ApprovingMode"" type=""ApprovingMode"">
      <DisplayName>$Ctd-GenericContent,ApprovingMode-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,ApprovingMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,ApprovingMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,ApprovingMode-2</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <DisplayName>$Ctd-GenericContent,InheritableApprovingMode-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,InheritableApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <ControlHint>sn:ApprovingModeChoice</ControlHint>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,InheritableApprovingMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,InheritableApprovingMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,InheritableApprovingMode-2</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""Locked"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,Locked-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Locked-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""CheckedOutTo"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,CheckedOutTo-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,CheckedOutTo-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""TrashDisabled"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,TrashDisabled-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,TrashDisabled-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DefaultValue>false</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""SavingState"" type=""Choice"">
      <DisplayName>$Ctd-GenericContent,SavingState-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,SavingState-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Enum type=""SenseNet.ContentRepository.Storage.ContentSavingState"" resourceClass=""Ctd"" />
        </Options>
      </Configuration>
    </Field>
    <Field name=""ExtensionData"" type=""LongText"">
      <DisplayName>$Ctd-GenericContent,ExtensionData-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,ExtensionData-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""BrowseApplication"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,BrowseApplication-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,BrowseApplication-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
      </Configuration>
    </Field>
    <Field name=""Approvable"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,Approvable-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Approvable-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""IsTaggable"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,IsTaggable-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,IsTaggable-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DefaultValue>false</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""Tags"" type=""LongText"">
      <DisplayName>$Ctd-GenericContent,Tags-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Tags-Description</Description>
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.TagIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <ReadOnly>false</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ControlHint>sn:TagList</ControlHint>
      </Configuration>
    </Field>
    <Field name=""IsRateable"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,IsRateable-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,IsRateable-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DefaultValue>false</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""RateStr"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,RateStr-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,RateStr-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""RateAvg"" type=""Number"">
      <DisplayName>$Ctd-GenericContent,RateAvg-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,RateAvg-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""RateCount"" type=""Integer"">
      <DisplayName>$Ctd-GenericContent,RateCount-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,RateCount-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Rate"" type=""Rating"">
      <DisplayName>$Ctd-GenericContent,Rate-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Rate-Description</Description>
      <Bind property=""RateStr"" />
      <Bind property=""RateCount"" />
      <Bind property=""RateAvg"" />
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <Range>5</Range>
      </Configuration>
    </Field>
    <Field name=""Publishable"" type=""Boolean"">
      <DisplayName>$Ctd-GenericContent,Publishable-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Publishable-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Versions"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,Versions-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Versions-Description</Description>
      <Indexing>
        <Mode>No</Mode>
        <Store>No</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""CheckInComments"" type=""LongText"">
      <DisplayName>$Ctd-GenericContent,CheckInComments-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,CheckInComments-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""RejectReason"" type=""LongText"">
      <DisplayName>$Ctd-GenericContent,RejectReason-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,RejectReason-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Workspace"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,Workspace-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Workspace-Description</Description>
      <Indexing>
        <Store>Yes</Store>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <ReadOnly>true</ReadOnly>
        <AllowedTypes>
          <Type>Workspace</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""BrowseUrl"" type=""ShortText"">
      <DisplayName>$Ctd-GenericContent,BrowseUrl-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,BrowseUrl-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Sharing"" type=""Sharing"">
      <DisplayName>$Ctd-GenericContent,Sharing-DisplayName</DisplayName>
      <Description>$Ctd-GenericContent,Sharing-Description</Description>
      <Indexing>
        <Analyzer>Keyword</Analyzer>
        <IndexHandler>SenseNet.Search.Indexing.SharingIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SharedWith"" type=""Sharing"">
      <Bind property=""Sharing""></Bind>
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.SharedWithIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""SharedBy"" type=""Sharing"">
      <Bind property=""Sharing""></Bind>
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.SharedByIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""SharingMode"" type=""Sharing"">
      <Bind property=""Sharing""></Bind>
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.SharingModeIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""SharingLevel"" type=""Sharing"">
      <Bind property=""Sharing""></Bind>
      <Indexing>
        <IndexHandler>SenseNet.Search.Indexing.SharingLevelIndexHandler</IndexHandler>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  25. GenericODataApplication
			{ "GenericODataApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""GenericODataApplication"" parentType=""Application"" handler=""SenseNet.Portal.ApplicationModel.GenericODataApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-GenericODataApplication,DisplayName</DisplayName>
  <Description>$Ctd-GenericODataApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields>
    <Field name=""ClassName"" type=""ShortText"">
      <DisplayName>$Ctd-GenericODataApplication,ClassName-DisplayName</DisplayName>
      <Description>$Ctd-GenericODataApplication,ClassName-Description</Description>
    </Field>
    <Field name=""MethodName"" type=""ShortText"">
      <DisplayName>$Ctd-GenericODataApplication,MethodName-DisplayName</DisplayName>
      <Description>$Ctd-GenericODataApplication,MethodName-Description</Description>
    </Field>
    <Field name=""Parameters"" type=""LongText"">
      <DisplayName>$Ctd-GenericODataApplication,Parameters-DisplayName</DisplayName>
      <Description>$Ctd-GenericODataApplication,Parameters-Description</Description>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  26. GetMetadataApplication
			{ "GetMetadataApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""GetMetadataApplication"" parentType=""HttpHandlerApplication"" handler=""SenseNet.Portal.Handlers.GetMetadataApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>GetMetadataApplication</DisplayName>
  <Fields />
</ContentType>
" },
			#endregion
			#region  27. Group
			{ "Group", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Group"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.Group"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Group,DisplayName</DisplayName>
  <Description>$Ctd-Group,Description</Description>
  <Icon>Group</Icon>
  <Fields>
    <Field name=""Members"" type=""Reference"">
      <DisplayName>$Ctd-Group,Members-DisplayName</DisplayName>
      <Description>$Ctd-Group,Members-Description</Description>
      <Configuration>
        <!--<ReadOnly>true</ReadOnly>-->
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
          <Type>Group</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
          <Path>/Root</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""SyncGuid"" type=""ShortText"">
      <DisplayName>$Ctd-Group,SyncGuid-DisplayName</DisplayName>
      <Description>$Ctd-Group,SyncGuid-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LastSync"" type=""DateTime"">
      <DisplayName>$Ctd-Group,LastSync-DisplayName</DisplayName>
      <Description>$Ctd-Group,LastSync-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  28. HtmlTemplate
			{ "HtmlTemplate", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""HtmlTemplate"" parentType=""File"" handler=""SenseNet.Portal.UI.HtmlTemplate"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-HtmlTemplate,DisplayName</DisplayName>
  <Description>$Ctd-HtmlTemplate,Description</Description>
  <Icon>File</Icon>
  <Fields>
    <Field name=""TemplateText"" type=""LongText"">
      <DisplayName>$Ctd-HtmlTemplate,TemplateText-DisplayName</DisplayName>
      <Description>$Ctd-HtmlTemplate,TemplateText-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <Readonly>true</Readonly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  29. HttpHandlerApplication
			{ "HttpHandlerApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""HttpHandlerApplication"" parentType=""Application"" handler=""SenseNet.Portal.Handlers.HttpHandlerApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-HttpHandlerApplication,DisplayName</DisplayName>
  <Description>$Ctd-HttpHandlerApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields />
</ContentType>
" },
			#endregion
			#region  30. HttpStatusApplication
			{ "HttpStatusApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""HttpStatusApplication"" parentType=""Application"" handler=""SenseNet.Portal.AppModel.HttpStatusApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-HttpStatusApplication,DisplayName</DisplayName>
  <Description>$Ctd-HttpStatusApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields>
    <Field name=""StatusCode"" type=""Choice"">
      <DisplayName>$Ctd-HttpStatusApplication,StatusCode-DisplayName</DisplayName>
      <Description>$Ctd-HttpStatusApplication,StatusCode-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <Compulsory>true</Compulsory>
        <Options>
          <Option value=""301"">$Ctd-HttpStatusApplication,StatusCode-301</Option>
          <Option value=""303"">$Ctd-HttpStatusApplication,StatusCode-303</Option>
          <Option value=""307"">$Ctd-HttpStatusApplication,StatusCode-307</Option>
          <Option value=""403"">$Ctd-HttpStatusApplication,StatusCode-403</Option>
          <Option value=""404"">$Ctd-HttpStatusApplication,StatusCode-404</Option>
          <Option value=""410"">$Ctd-HttpStatusApplication,StatusCode-410</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""RedirectUrl"" type=""ShortText"">
      <DisplayName>$Ctd-HttpStatusApplication,RedirectUrl-DisplayName</DisplayName>
      <Description>$Ctd-HttpStatusApplication,RedirectUrl-Description</Description>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  31. HyperLinkFieldSetting
			{ "HyperLinkFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""HyperLinkFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-HyperLinkFieldSetting,DisplayName</DisplayName>
  <Icon>addhyperlinkfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  32. Image
			{ "Image", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Image"" parentType=""File"" handler=""SenseNet.ContentRepository.Image"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Image,DisplayName</DisplayName>
  <Description>$Ctd-Image,Description</Description>
  <Icon>Image</Icon>
  <Preview>true</Preview>
  <Fields>
    <Field name=""Keywords"" type=""LongText"">
      <DisplayName>$Ctd-Image,Keywords-DisplayName</DisplayName>
      <Description>$Ctd-Image,Keywords-Description</Description>
    </Field>
    <Field name=""DateTaken"" type=""DateTime"">
      <DisplayName>$Ctd-Image,DateTaken-DisplayName</DisplayName>
      <Description>$Ctd-Image,DateTaken-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer""></Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Width"" type=""Integer"">
      <DisplayName>$Ctd-Image,Width-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Height"" type=""Integer"">
      <DisplayName>$Ctd-Image,Height-DisplayName</DisplayName>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  33. ImageLibrary
			{ "ImageLibrary", @"<ContentType name=""ImageLibrary"" parentType=""Library"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ImageLibrary,DisplayName</DisplayName>
  <Description>$Ctd-ImageLibrary,Description</Description>
  <Icon>ContentList</Icon>
  <AllowedChildTypes>
    Folder,Image
  </AllowedChildTypes>
  <Fields>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""CoverImage"" type=""Reference"">
      <DisplayName>$Ctd-GenericContent,CoverImage</DisplayName>
      <Description>Select cover image</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>Image</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  34. ImgResizeApplication
			{ "ImgResizeApplication", @"<ContentType name=""ImgResizeApplication"" parentType=""Application"" handler=""SenseNet.Portal.ApplicationModel.ImgResizeApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ImgResizeApplication,DisplayName</DisplayName>
  <Description>$Ctd-ImgResizeApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields>
    <Field name=""ResizeTypeMode"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,ResizeTypeMode-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,ResizeTypeMode-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <Options>
          <Option selected=""true"" value=""Resize"">$Ctd-ImgResizeApplication,ResizeTypeMode-Resize</Option>
          <Option value=""Crop"">$Ctd-ImgResizeApplication,ResizeTypeMode-Crop</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""ImageType"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,ImageType-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,ImageType-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <Options>
          <Option value=""Binary"">$Ctd-ImgResizeApplication,ImageType-Binary</Option>
          <Option value=""Reference"">$Ctd-ImgResizeApplication,ImageType-Reference</Option>
          <Option value=""ImageData"">$Ctd-ImgResizeApplication,ImageType-ImageData</Option>
          <Option value=""Attachment"">$Ctd-ImgResizeApplication,ImageType-Attachment</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""ImageFieldName"" type=""ShortText"">
      <DisplayName>$Ctd-ImgResizeApplication,ImageFieldName-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,ImageFieldName-Description</Description>
    </Field>
    <Field name=""Width"" type=""Integer"">
      <DisplayName>$Ctd-ImgResizeApplication,Width-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,Width-Description</Description>
    </Field>
    <Field name=""Height"" type=""Integer"">
      <DisplayName>$Ctd-ImgResizeApplication,Height-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,Height-Description</Description>
    </Field>
    <Field name=""Stretch"" type=""Boolean"">
      <DisplayName>$Ctd-ImgResizeApplication,Stretch-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,Stretch-Description</Description>
      <Configuration>
        <Visible>true</Visible>
        <DefaultValue>false</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""OutputFormat"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,OutputFormat-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,OutputFormat-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option selected=""true"" value=""Auto"">$Ctd-ImgResizeApplication,OutputFormat-Auto</Option>
          <Option value=""Jpeg"">$Ctd-ImgResizeApplication,OutputFormat-Jpeg</Option>
          <Option value=""Png"">$Ctd-ImgResizeApplication,OutputFormat-Png</Option>
          <Option value=""Gif"">$Ctd-ImgResizeApplication,OutputFormat-Gif</Option>
          <Option value=""Icon"">$Ctd-ImgResizeApplication,OutputFormat-Icon</Option>
          <Option value=""Tiff"">$Ctd-ImgResizeApplication,OutputFormat-Tiff</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""SmoothingMode"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,SmoothingMode-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,SmoothingMode-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option selected=""true"" value=""AntiAlias"">$Ctd-ImgResizeApplication,SmoothingMode-AntiAlias</Option>
          <Option value=""Default"">$Ctd-ImgResizeApplication,SmoothingMode-Default</Option>
          <Option value=""HighQuality"">$Ctd-ImgResizeApplication,SmoothingMode-HighQuality</Option>
          <Option value=""HighSpeed"">$Ctd-ImgResizeApplication,SmoothingMode-HighSpeed</Option>
          <Option value=""Invalid"">$Ctd-ImgResizeApplication,SmoothingMode-Invalid</Option>
          <Option value=""None"">$Ctd-ImgResizeApplication,SmoothingMode-None</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""InterpolationMode"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,InterpolationMode-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,InterpolationMode-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option value=""Invalid"">$Ctd-ImgResizeApplication,InterpolationMode-Invalid</Option>
          <Option value=""Default"">$Ctd-ImgResizeApplication,InterpolationMode-Default</Option>
          <Option value=""Low"">$Ctd-ImgResizeApplication,InterpolationMode-Low</Option>
          <Option value=""High"">$Ctd-ImgResizeApplication,InterpolationMode-High</Option>
          <Option value=""Bilinear"">$Ctd-ImgResizeApplication,InterpolationMode-Bilinear</Option>
          <Option value=""Bicubic"">$Ctd-ImgResizeApplication,InterpolationMode-Bicubic</Option>
          <Option value=""NearestNeighbor"">$Ctd-ImgResizeApplication,InterpolationMode-NearestNeighbor</Option>
          <Option value=""HighQualityBilinear"">$Ctd-ImgResizeApplication,InterpolationMode-HighQualityBilinear</Option>
          <Option selected=""true"" value=""HighQualityBicubic"">$Ctd-ImgResizeApplication,InterpolationMode-HighQualityBicubic</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""PixelOffsetMode"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,PixelOffsetMode-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,PixelOffsetMode-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option value=""Invalid"">$Ctd-ImgResizeApplication,PixelOffsetMode-Invalid</Option>
          <Option value=""Default"">$Ctd-ImgResizeApplication,PixelOffsetMode-Default</Option>
          <Option value=""HighSpeed"">$Ctd-ImgResizeApplication,PixelOffsetMode-HighSpeed</Option>
          <Option selected=""true"" value=""HighQuality"">$Ctd-ImgResizeApplication,PixelOffsetMode-HighQuality</Option>
          <Option value=""None"">$Ctd-ImgResizeApplication,PixelOffsetMode-None</Option>
          <Option value=""Half"">$Ctd-ImgResizeApplication,PixelOffsetMode-Half</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""CropHAlign"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,CropHAlign-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,CropHAlign-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <AllowExtraValue>true</AllowExtraValue>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option selected=""true"" value=""Left"">$Ctd-ImgResizeApplication,CropHAlign-Left</Option>
          <Option value=""Center"">$Ctd-ImgResizeApplication,CropHAlign-Center</Option>
          <Option value=""Right"">$Ctd-ImgResizeApplication,CropHAlign-Right</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""CropVAlign"" type=""Choice"">
      <DisplayName>$Ctd-ImgResizeApplication,CropVAlign-DisplayName</DisplayName>
      <Description>$Ctd-ImgResizeApplication,CropVAlign-Description</Description>
      <Configuration>
        <AllowMultiple>False</AllowMultiple>
        <AllowExtraValue>true</AllowExtraValue>
        <VisibleNew>Advanced</VisibleNew>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <Options>
          <Option selected=""true"" value=""Top"">$Ctd-ImgResizeApplication,CropVAlign-Top</Option>
          <Option value=""Center"">$Ctd-ImgResizeApplication,CropVAlign-Center</Option>
          <Option value=""Bottom"">$Ctd-ImgResizeApplication,CropVAlign-Bottom</Option>
        </Options>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  35. IndexingSettings
			{ "IndexingSettings", @"<ContentType name=""IndexingSettings"" parentType=""Settings"" handler=""SenseNet.Search.IndexingSettings"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-IndexingSettings,DisplayName</DisplayName>
  <Description>$Ctd-IndexingSettings,Description</Description>
  <Icon>Settings</Icon>
  <Fields>
    <Field name=""TextExtractorInstances"" type=""TextExtractors"">
      <DisplayName>$Ctd-IndexingSettings,TextExtractorInstances-DisplayName</DisplayName>
      <Description>$Ctd-IndexingSettings,TextExtractorInstances-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  36. IntegerFieldSetting
			{ "IntegerFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""IntegerFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-IntegerFieldSetting,DisplayName</DisplayName>
  <Icon>addnumberfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  37. ItemList
			{ "ItemList", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ItemList"" parentType=""ContentList"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ItemList,DisplayName</DisplayName>
  <Description>$Ctd-ItemList,Description</Description>
  <Icon>ContentList</Icon>
  <Fields>
    <Field name=""OwnerWhenVisitor"" type=""Reference"">
      <DisplayName>$Ctd-ContentList,OwnerWhenVisitor-DisplayName</DisplayName>
      <Description>$Ctd-ContentList,OwnerWhenVisitor-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
        </SelectionRoot>
        <DefaultValue>/Root/IMS/BuiltIn/Portal/Admin</DefaultValue>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <DisplayName>$Ctd-GenericContent,InheritableVersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-ItemList,ItemListInheritableVersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>

    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <DisplayName>$Ctd-GenericContent,InheritableApprovingMode-DisplayName</DisplayName>
      <Description>$Ctd-ItemList,ItemListInheritableApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  38. Library
			{ "Library", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Library"" parentType=""ContentList"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Library,DisplayName</DisplayName>
  <Description>$Ctd-Library,Description</Description>
  <Icon>ContentList</Icon>
  <Fields>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <DisplayName>$Ctd-GenericContent,InheritableVersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-Library,LibraryInheritableVersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>

    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <DisplayName>$Ctd-GenericContent,InheritableApprovingMode-DisplayName</DisplayName>
      <Description>$Ctd-Library,LibraryInheritableApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  39. ListItem
			{ "ListItem", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ListItem"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.GenericContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ListItem,DisplayName</DisplayName>
  <Description>$Ctd-ListItem,Description</Description>
  <Icon>FormItem</Icon>
  <Fields>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <OutputMethod>Html</OutputMethod>
      </Configuration>
    </Field>
    <Field name=""ModifiedBy"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""ModificationDate"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  40. LoggingSettings
			{ "LoggingSettings", @"<ContentType name=""LoggingSettings"" parentType=""Settings"" handler=""SenseNet.ContentRepository.LoggingSettings"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-LoggingSettings,DisplayName</DisplayName>
  <Description>$Ctd-LoggingSettings,Description</Description>
  <Icon>Settings</Icon>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  41. LongTextFieldSetting
			{ "LongTextFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""LongTextFieldSetting"" parentType=""TextFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-LongTextFieldSetting,DisplayName</DisplayName>
  <Icon>addshorttextfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  42. Memo
			{ "Memo", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Memo"" parentType=""ListItem"" handler=""SenseNet.ContentRepository.GenericContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Memo,DisplayName</DisplayName>
  <Description>$Ctd-Memo,Description</Description>
  <Icon>Document</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <Fields>
    <Field name=""Description"" type=""LongText"">
      <DisplayName>$Ctd-Memo,Description-DisplayName</DisplayName>
      <Description>$Ctd-Memo,Description-Description</Description>
    </Field>
    <Field name=""Date"" type=""DateTime"">
      <DisplayName>$Ctd-Memo,Date-DisplayName</DisplayName>
      <Description>$Ctd-Memo,Date-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""MemoType"" type=""Choice"">
      <DisplayName>$Ctd-Memo,MemoType-DisplayName</DisplayName>
      <Description>$Ctd-Memo,MemoType-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>true</AllowExtraValue>
        <Options>
          <Option value=""generic"" selected=""true"">$Ctd-Memo,MemoType-generic</Option>
          <Option value=""iso"">$Ctd-Memo,MemoType-iso</Option>
          <Option value=""iaudit"">$Ctd-Memo,MemoType-iaudit</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""SeeAlso"" type=""Reference"">
      <DisplayName>$Ctd-Memo,SeeAlso-DisplayName</DisplayName>
      <Description>$Ctd-Memo,SeeAlso-Description</Description>
      <Configuration>
        <AllowMultiple>true</AllowMultiple>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  43. MemoList
			{ "MemoList", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""MemoList"" parentType=""ItemList"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-MemoList,DisplayName</DisplayName>
  <Description>$Ctd-MemoList,Description</Description>
  <Icon>ContentList</Icon>
  <AllowedChildTypes>
    Memo
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  44. NullFieldSetting
			{ "NullFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""NullFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-NullFieldSetting,DisplayName</DisplayName>
  <Icon>File</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  45. NumberFieldSetting
			{ "NumberFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""NumberFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-NumberFieldSetting,DisplayName</DisplayName>
  <Icon>addnumberfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  46. OrganizationalUnit
			{ "OrganizationalUnit", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""OrganizationalUnit"" parentType=""Folder"" handler=""SenseNet.ContentRepository.OrganizationalUnit"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-OrganizationalUnit,DisplayName</DisplayName>
  <Description>$Ctd-OrganizationalUnit,Description</Description>
  <Icon>OrgUnit</Icon>
  <AllowedChildTypes>
    User,RegisteredUser,Group,OrganizationalUnit,ADFolder
  </AllowedChildTypes>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SyncGuid"" type=""ShortText"">
      <DisplayName>$Ctd-OrganizationalUnit,SyncGuid-DisplayName</DisplayName>
      <Description>$Ctd-OrganizationalUnit,SyncGuid-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LastSync"" type=""DateTime"">
      <DisplayName>$Ctd-OrganizationalUnit,LastSync-DisplayName</DisplayName>
      <Description>$Ctd-OrganizationalUnit,LastSync-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  47. PasswordFieldSetting
			{ "PasswordFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""PasswordFieldSetting"" parentType=""ShortTextFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-PasswordFieldSetting,DisplayName</DisplayName>
  <Icon>addshorttextfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  48. PermissionChoiceFieldSetting
			{ "PermissionChoiceFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""PermissionChoiceFieldSetting"" parentType=""ChoiceFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-PermissionChoiceFieldSetting,DisplayName</DisplayName>
  <Icon>File</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  49. PortalRoot
			{ "PortalRoot", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""PortalRoot"" parentType=""Folder"" handler=""SenseNet.ContentRepository.PortalRoot"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-PortalRoot,DisplayName</DisplayName>
  <Description>$Ctd-PortalRoot,Description</Description>
  <Icon>PortalRoot</Icon>
  <AllowedChildTypes>
    Folder,SystemFolder,TrashBin,ContentList,CustomList,Sites,Domains,Profiles,Resources,Skins,Workspace
  </AllowedChildTypes>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  50. PortalSettings
			{ "PortalSettings", @"<ContentType name=""PortalSettings"" parentType=""Settings"" handler=""SenseNet.Portal.PortalSettings"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-PortalSettings,DisplayName</DisplayName>
  <Description>$Ctd-PortalSettings,Description</Description>
  <Icon>Settings</Icon>
  <Fields>
  </Fields>
</ContentType>
" },
			#endregion
			#region  51. PreviewImage
			{ "PreviewImage", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""PreviewImage"" parentType=""Image"" handler=""SenseNet.ContentRepository.Image"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-PreviewImage,DisplayName</DisplayName>
  <Description>$Ctd-PreviewImage,Description</Description>
  <Icon>Image</Icon>
  <AllowIncrementalNaming>false</AllowIncrementalNaming>
  <AllowIndexing>false</AllowIndexing>
  <Fields>
  </Fields>
</ContentType>

" },
			#endregion
			#region  52. ProfileDomain
			{ "ProfileDomain", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ProfileDomain"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ProfileDomain,DisplayName</DisplayName>
  <Description>$Ctd-ProfileDomain,Description</Description>
  <Icon>Domain</Icon>
  <AllowedChildTypes>
    UserProfile
  </AllowedChildTypes>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-ProfileDomain,DisplayName-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  53. Profiles
			{ "Profiles", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Profiles"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Profiles,DisplayName</DisplayName>
  <Description>$Ctd-Profiles,Description</Description>
  <Icon>Folder</Icon>
  <AllowedChildTypes>
    ProfileDomain
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  54. Query
			{ "Query", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Query"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.QueryContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Query,DisplayName</DisplayName>
  <Description>$Ctd-Query,Description</Description>
  <Icon>Query</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <Fields>
    <Field name=""Query"" type=""LongText"">
      <DisplayName>$Ctd-Query,Query-DisplayName</DisplayName>
      <Description>$Ctd-Query,Query-Description</Description>
      <Configuration>
        <ControlHint>sn:QueryBuilder</ControlHint>
      </Configuration>
    </Field>
    <Field name=""QueryType"" type=""Choice"">
      <DisplayName>$Ctd-Query,QueryType-DisplayName</DisplayName>
      <Description>$Ctd-Query,QueryType-Description</Description>
      <Configuration>
        <Options>
          <Option selected=""true"" value=""Public"">$Ctd-Query,QueryType-Public</Option>
          <Option value=""Private"">$Ctd-Query,QueryType-Private</Option>
        </Options>
        <ReadOnly>True</ReadOnly>
        <DisplayChoices>RadioButtons</DisplayChoices>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  55. ReferenceFieldSetting
			{ "ReferenceFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ReferenceFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ReferenceFieldSetting,DisplayName</DisplayName>
  <Icon>addreferencefield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  56. Resource
			{ "Resource", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Resource"" parentType=""SystemFile"" handler=""SenseNet.ContentRepository.i18n.Resource"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Resource,DisplayName</DisplayName>
  <Description>$Ctd-Resource,Description</Description>
  <Icon>Resource</Icon>
  <Fields>
    <Field name=""Binary"" type=""Binary"">
      <DisplayName>$Ctd-Resource,Binary-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <IsText>true</IsText>
      </Configuration>
    </Field>
    <Field name=""Downloads"" type=""Number"">
      <DisplayName>$Ctd-Resource,Downloads-DisplayName</DisplayName>
      <Description>$Ctd-Resource,Downloads-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Size"" type=""Number"">
      <DisplayName>$Ctd-Resource,Size-DisplayName</DisplayName>
      <Description>$Ctd-Resource,Size-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""FullSize"" type=""Number"">
      <DisplayName>$Ctd-Resource,FullSize-DisplayName</DisplayName>
      <Description>$Ctd-Resource,FullSize-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  57. Resources
			{ "Resources", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Resources"" parentType=""SystemFolder"" handler=""SenseNet.ContentRepository.SystemFolder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Resources,DisplayName</DisplayName>
  <Description>$Ctd-Resources,Description</Description>
  <Icon>Folder</Icon>
  <AllowedChildTypes>
    Resource
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  58. RssApplication
			{ "RssApplication", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""RssApplication"" parentType=""Application"" handler=""SenseNet.Services.RssApplication"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-RssApplication,DisplayName</DisplayName>
  <Description>$Ctd-RssApplication,Description</Description>
  <Icon>Application</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  59. RuntimeContentContainer
			{ "RuntimeContentContainer", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""RuntimeContentContainer"" parentType=""Folder"" handler=""SenseNet.ContentRepository.RuntimeContentContainer"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-RuntimeContentContainer,DisplayName</DisplayName>
  <Description>$Ctd-RuntimeContentContainer,Description</Description>
  <Icon>Folder</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  60. Settings
			{ "Settings", @"<ContentType name=""Settings"" parentType=""File"" handler=""SenseNet.ContentRepository.Settings"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Settings,DisplayName</DisplayName>
  <Description>$Ctd-Settings,Description</Description>
  <Icon>Settings</Icon>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <DefaultValue>.settings</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Watermark"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""GlobalOnly"" type=""Boolean"">
      <DisplayName>$Ctd-Settings,GlobalOnly-DisplayName</DisplayName>
      <Description>$Ctd-Settings,GlobalOnly-Description</Description>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  61. SharingGroup
			{ "SharingGroup", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""SharingGroup"" parentType=""Group"" handler=""SenseNet.ContentRepository.Group"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>SharingGroup</DisplayName>
  <Icon>Group</Icon>
  <Fields>
    <Field name=""SharingIds"" type=""LongText"">
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SharingLevelValue"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SharedContent"" type=""Reference"">
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  62. ShortTextFieldSetting
			{ "ShortTextFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""ShortTextFieldSetting"" parentType=""TextFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-ShortTextFieldSetting,DisplayName</DisplayName>
  <Icon>addshorttextfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  63. Site
			{ "Site", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Site"" parentType=""Workspace"" handler=""SenseNet.Portal.Site"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Site,DisplayName</DisplayName>
  <Description>$Ctd-Site,Description</Description>
  <Icon>Site</Icon>
  <AllowedChildTypes>
    Folder,Workspace,
    Profiles,Image,DocumentLibrary,ImageLibrary,EventList,MemoList,
    LinkList,TaskList,Form,CustomList,SmartFolder
  </AllowedChildTypes>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Site,DisplayName-DisplayName</DisplayName>
      <Description>$Ctd-Site,DisplayName-Description</Description>
    </Field>
    <Field name=""Language"" type=""Choice"">
      <DisplayName>$Ctd-Site,Language-DisplayName</DisplayName>
      <Description>$Ctd-Site,Language-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""en"" selected='true'>$Ctd-Site,Language-En</Option>
          <Option value=""hu"">$Ctd-Site,Language-Hu</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""EnableClientBasedCulture"" type=""Boolean"">
      <DisplayName>$Ctd-Site,EnableClientBasedCulture-DisplayName</DisplayName>
      <Description>$Ctd-Site,EnableClientBasedCulture-Description</Description>
    </Field>
    <Field name=""EnableUserBasedCulture"" type=""Boolean"">
      <DisplayName>$Ctd-Site,EnableUserBasedCulture-DisplayName</DisplayName>
      <Description>$Ctd-Site,EnableUserBasedCulture-Description</Description>
    </Field>
    <Field name=""UrlList"" type=""UrlList"">
      <DisplayName>$Ctd-Site,UrlList-DisplayName</DisplayName>
      <Description>$Ctd-Site,UrlList-Description</Description>
    </Field>
    <Field name=""StartPage"" type=""Reference"">
      <DisplayName>$Ctd-Site,StartPage-DisplayName</DisplayName>
      <Description>$Ctd-Site,StartPage-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <SelectionRoot>
          <Path>.</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""LoginPage"" type=""Reference"">
      <DisplayName>$Ctd-Site,LoginPage-DisplayName</DisplayName>
      <Description>$Ctd-Site,LoginPage-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <SelectionRoot>
          <Path>.</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""IsActive"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""SiteSkin"" type=""Reference"">
      <DisplayName>$Ctd-Site,SiteSkin-DisplayName</DisplayName>
      <Description>$Ctd-Site,SiteSkin-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>Skin</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/Skins</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""WorkspaceSkin"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsWallContainer"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsCritical"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Manager"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Deadline"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DenyCrossSiteAccess"" type=""Boolean"">
      <DisplayName>$Ctd-Site,DenyCrossSiteAccess-DisplayName</DisplayName>
      <Description>$Ctd-Site,DenyCrossSiteAccess-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <DisplayName>$Ctd-GenericContent,InheritableVersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-Site,SiteInheritableVersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <ControlHint>sn:VersioningModeChoice</ControlHint>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,InheritableVersioningMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,InheritableVersioningMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,InheritableVersioningMode-2</Option>
          <Option value=""3"">$Ctd-GenericContent,InheritableVersioningMode-3</Option>
        </Options>
      </Configuration>
    </Field>

    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <DisplayName>$Ctd-GenericContent,InheritableApprovingMode-DisplayName</DisplayName>
      <Description>$Ctd-Site,SiteInheritableApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <ControlHint>sn:ApprovingModeChoice</ControlHint>
        <Options>
          <Option selected=""true"" value=""0"">$Ctd-GenericContent,InheritableApprovingMode-0</Option>
          <Option value=""1"">$Ctd-GenericContent,InheritableApprovingMode-1</Option>
          <Option value=""2"">$Ctd-GenericContent,InheritableApprovingMode-2</Option>
        </Options>
      </Configuration>
    </Field>
  </Fields>
</ContentType>
" },
			#endregion
			#region  64. Sites
			{ "Sites", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Sites"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Folder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Sites,DisplayName</DisplayName>
  <Description>$Ctd-Sites,Description</Description>
  <Icon>Site</Icon>
  <AllowedChildTypes>
    Site
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  65. SmartFolder
			{ "SmartFolder", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""SmartFolder"" parentType=""Folder"" handler=""SenseNet.ContentRepository.SmartFolder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-SmartFolder,DisplayName</DisplayName>
  <Description>$Ctd-SmartFolder,Description</Description>
  <Icon>SmartFolder</Icon>
  <Fields>
    <Field name=""Query"" type=""LongText"">
      <DisplayName>$Ctd-SmartFolder,Query-DisplayName</DisplayName>
      <Description>$Ctd-SmartFolder,Query-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <ControlHint>sn:QueryBuilder</ControlHint>
      </Configuration>
    </Field>
    <Field name=""EnableAutofilters"" type=""Choice"">
      <DisplayName>$Ctd-SmartFolder,EnableAutofilters-DisplayName</DisplayName>
      <Description>$Ctd-SmartFolder,EnableAutofilters-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Enum type=""SenseNet.Search.FilterStatus"" />
        </Options>
      </Configuration>
    </Field>
    <Field name=""EnableLifespanFilter"" type=""Choice"">
      <DisplayName>$Ctd-SmartFolder,EnableLifespanFilter-DisplayName</DisplayName>
      <Description>$Ctd-SmartFolder,EnableLifespanFilter-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Enum type=""SenseNet.Search.FilterStatus"" />
        </Options>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  66. SystemFile
			{ "SystemFile", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""SystemFile"" parentType=""File"" handler=""SenseNet.ContentRepository.File"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-SystemFile,DisplayName</DisplayName>
  <Description>$Ctd-SystemFile,Description</Description>
  <Icon>File</Icon>
  <Fields>
    <Field name=""Watermark"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  67. SystemFolder
			{ "SystemFolder", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""SystemFolder"" parentType=""Folder"" handler=""SenseNet.ContentRepository.SystemFolder"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-SystemFolder,DisplayName</DisplayName>
  <Description>$Ctd-SystemFolder,Description</Description>
  <Icon>Folder</Icon>
  <Fields>
  <Field name=""DisplayName"" type=""ShortText"">
    <DisplayName>$Ctd-SystemFolder,DisplayName-DisplayName</DisplayName>
    <Description>$Ctd-SystemFolder,DisplayName-Description</Description>
  </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  68. Task
			{ "Task", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Task"" parentType=""ListItem"" handler=""SenseNet.ContentRepository.Task"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Task,DisplayName</DisplayName>
  <Description>$Ctd-Task,Description</Description>
  <Icon>FormItem</Icon>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""StartDate"" type=""DateTime"">
      <DisplayName>$Ctd-Task,StartDate-DisplayName</DisplayName>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""DueDate"" type=""DateTime"">
      <DisplayName>$Ctd-Task,DueDate-DisplayName</DisplayName>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <Compulsory>true</Compulsory>
      </Configuration>
    </Field>
    <Field name=""AssignedTo"" type=""Reference"">
      <DisplayName>$Ctd-Task,AssignedTo-DisplayName</DisplayName>
      <Description>$Ctd-Task,AssignedTo-Description</Description>
      <Configuration>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
          <Path>/Root</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""Priority"" type=""Choice"">
      <DisplayName>$Ctd-Task,Priority-DisplayName</DisplayName>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""1"">$Ctd-Task,Priority-1</Option>
          <Option value=""2"" selected=""true"">$Ctd-Task,Priority-2</Option>
          <Option value=""3"">$Ctd-Task,Priority-3</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""Status"" type=""Choice"">
      <DisplayName>$Ctd-Task,Status-DisplayName</DisplayName>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""pending"">$Ctd-Task,Status-pending</Option>
          <Option value=""active"" selected=""true"">$Ctd-Task,Status-active</Option>
          <Option value=""completed"">$Ctd-Task,Status-completed</Option>
          <Option value=""deferred"">$Ctd-Task,Status-deferred</Option>
          <Option value=""waiting"">$Ctd-Task,Status-waiting</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""TaskCompletion"" type=""Integer"">
      <DisplayName>$Ctd-Task,TaskCompletion-DisplayName</DisplayName>
      <Description>$Ctd-Task,TaskCompletion-Description</Description>
      <Configuration>
        <ShowAsPercentage>true</ShowAsPercentage>
        <MinValue>0</MinValue>
        <MaxValue>100</MaxValue>
      </Configuration>
    </Field>
    <Field name=""RemainingDays"" type=""Integer"">
      <DisplayName>$Ctd-Task,RemainingDays-DisplayName</DisplayName>
      <Description>$Ctd-Task,RemainingDays-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""DueText"" type=""ShortText"">
      <DisplayName>$Ctd-Task,DueText-DisplayName</DisplayName>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DueCssClass"" type=""ShortText"">
      <DisplayName>$Ctd-Task,DueCssClass-DisplayName</DisplayName>
      <Description>$Ctd-Task,DueCssClass-Description</Description>
      <Indexing>
        <Mode>No</Mode>
      </Indexing>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  69. TaskList
			{ "TaskList", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""TaskList"" parentType=""ItemList"" handler=""SenseNet.ContentRepository.ContentList"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-TaskList,DisplayName</DisplayName>
  <Description>$Ctd-TaskList,Description</Description>
  <Icon>ContentList</Icon>
  <AllowedChildTypes>
    Task,ApprovalWorkflowTask,ExpenseClaimWorkflowTask
  </AllowedChildTypes>
  <Fields></Fields>
</ContentType>" },
			#endregion
			#region  70. TextFieldSetting
			{ "TextFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""TextFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-TextFieldSetting,DisplayName</DisplayName>
  <Icon>addshorttextfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  71. TrashBag
			{ "TrashBag", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""TrashBag"" parentType=""Folder"" handler=""SenseNet.ContentRepository.TrashBag"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-TrashBag,DisplayName</DisplayName>
  <Description>$Ctd-TrashBag,Description</Description>
  <Icon>Folder</Icon>
  <AllowIncrementalNaming>true</AllowIncrementalNaming>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-TrashBag,DisplayName-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""KeepUntil"" type=""DateTime"">
      <DisplayName>$Ctd-TrashBag,KeepUntil-DisplayName</DisplayName>
      <Description>$Ctd-TrashBag,KeepUntil-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""OriginalPath"" type=""ShortText"">
      <DisplayName>$Ctd-TrashBag,OriginalPath-DisplayName</DisplayName>
      <Description>$Ctd-TrashBag,OriginalPath-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""WorkspaceRelativePath"" type=""ShortText"">
      <DisplayName>$Ctd-TrashBag,WorkspaceRelativePath-DisplayName</DisplayName>
      <Description>$Ctd-TrashBag,WorkspaceRelativePath-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""WorkspaceId"" type=""Integer"">
      <DisplayName>$Ctd-TrashBag,WorkspaceId-DisplayName</DisplayName>
      <Description>$Ctd-TrashBag,WorkspaceId-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DeletedContent"" type=""Reference"">
      <DisplayName>$Ctd-TrashBag,DeletedContent-DisplayName</DisplayName>
      <Description>$Ctd-TrashBag,DeletedContent-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  72. TrashBin
			{ "TrashBin", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""TrashBin"" parentType=""Workspace"" handler=""SenseNet.ContentRepository.TrashBin"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-TrashBin,DisplayName</DisplayName>
  <Description>$Ctd-TrashBin,Description</Description>
  <Icon>trash</Icon>
  <AllowedChildTypes>
    TrashBag
  </AllowedChildTypes>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Index"" type=""Integer"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsActive"" type=""Boolean"">
      <DisplayName>$Ctd-TrashBin,IsActive-DisplayName</DisplayName>
      <Description>$Ctd-TrashBin,IsActive-Description</Description>
    </Field>
    <Field name=""MinRetentionTime"" type=""Integer"">
      <DisplayName>$Ctd-TrashBin,MinRetentionTime-DisplayName</DisplayName>
      <Description>$Ctd-TrashBin,MinRetentionTime-Description</Description>
      <Configuration>
        <MinValue>0</MinValue>
      </Configuration>
    </Field>
    <Field name=""SizeQuota"" type=""Integer"">
      <DisplayName>$Ctd-TrashBin,SizeQuota-DisplayName</DisplayName>
      <Description>$Ctd-TrashBin,SizeQuota-Description</Description>
      <Configuration>
        <MinValue>0</MinValue>
      </Configuration>
    </Field>
    <Field name=""BagCapacity"" type=""Integer"">
      <DisplayName>$Ctd-TrashBin,BagCapacity-DisplayName</DisplayName>
      <Description>$Ctd-TrashBin,BagCapacity-Description</Description>
      <Configuration>
        <DefaultValue>100</DefaultValue>
        <MinValue>0</MinValue>
      </Configuration>
    </Field>
    <Field name=""TrashDisabled"" type=""Boolean"">
      <Configuration>
        <DefaultValue>true</DefaultValue>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsWallContainer"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsCritical"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Manager"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Deadline"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""WorkspaceSkin"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Version"" type=""Version"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  73. User
			{ "User", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""User"" parentType=""GenericContent"" handler=""SenseNet.ContentRepository.User"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-User,DisplayName</DisplayName>
  <Description>$Ctd-User,Description</Description>
  <Icon>User</Icon>
  <AllowedChildTypes>
    Image
  </AllowedChildTypes>
  <Fields>
    <Field name=""Name"" type=""ShortText"">
      <DisplayName>$Ctd-User,Name-DisplayName</DisplayName>
      <Description>$Ctd-User,Name-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <Compulsory>true</Compulsory>
        <MaxLength>20</MaxLength>
        <ControlHint>sn:ShortText</ControlHint>
      </Configuration>
    </Field>
    <Field name=""LoginName"" type=""ShortText"">
      <DisplayName>$Ctd-User,LoginName-DisplayName</DisplayName>
      <Description>$Ctd-User,LoginName-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <Compulsory>true</Compulsory>
        <MaxLength>100</MaxLength>
      </Configuration>
    </Field>
    <Field name=""DisplayName"" type=""ShortText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""JobTitle"" type=""ShortText"">
      <DisplayName>$Ctd-User,JobTitle-DisplayName</DisplayName>
      <Description>$Ctd-User,JobTitle-Description</Description>
    </Field>
    <Field name=""Enabled"" type=""Boolean"">
      <DisplayName>$Ctd-User,Enabled-DisplayName</DisplayName>
      <Description>$Ctd-User,Enabled-Description</Description>
    </Field>
    <Field name=""Domain"" type=""ShortText"">
      <DisplayName>$Ctd-User,Domain-DisplayName</DisplayName>
      <Description>$Ctd-User,Domain-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
      </Configuration>
    </Field>
    <Field name=""Email"" type=""ShortText"">
      <DisplayName>$Ctd-User,Email-DisplayName</DisplayName>
      <Description>$Ctd-User,Email-Description</Description>
      <Configuration>
        <Compulsory>true</Compulsory>
        <Regex>^[a-zA-Z0-9._%+-]+@(?:[a-zA-Z0-9-]+\.)+[a-zA-Z]{2,}$</Regex>
      </Configuration>
    </Field>
    <Field name=""FullName"" type=""ShortText"">
      <DisplayName>$Ctd-User,FullName-DisplayName</DisplayName>
      <Description>$Ctd-User,FullName-Description</Description>
      <Configuration>
        <Compulsory>true</Compulsory>
        <Regex>[^&lt;]+</Regex>
      </Configuration>
    </Field>
    <Field name=""ImageRef"" type=""Reference"">
      <DisplayName>$Ctd-User,ImageRef-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
      </Configuration>
    </Field>
    <Field name=""ImageData"" type=""Binary"">
      <DisplayName>$Ctd-User,ImageData-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Avatar"" type=""Image"">
      <DisplayName>$Ctd-User,Avatar-DisplayName</DisplayName>
      <Description>$Ctd-User,Avatar-Description</Description>
      <Bind property=""ImageRef"" />
      <Bind property=""ImageData"" />
      <Configuration>
        <Visible>true</Visible>
        <ControlHint>sn:Image</ControlHint>
      </Configuration>
    </Field>
    <Field name=""Password"" type=""Password"">
      <DisplayName>$Ctd-User,Password-DisplayName</DisplayName>
      <Description>$Ctd-User,Password-Description</Description>
      <Bind property=""PasswordHash""></Bind>
      <Configuration>
        <Compulsory>true</Compulsory>
        <ReenterTitle>$Ctd-User,Password-ReenterTitle</ReenterTitle>
        <ReenterDescription>$Ctd-User,Password-ReenterDescription</ReenterDescription>
      </Configuration>
    </Field>
    <Field name=""SyncGuid"" type=""ShortText"">
      <DisplayName>$Ctd-User,SyncGuid-DisplayName</DisplayName>
      <Description>$Ctd-User,SyncGuid-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LastSync"" type=""DateTime"">
      <DisplayName>$Ctd-User,LastSync-DisplayName</DisplayName>
      <Description>$Ctd-User,LastSync-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Captcha"" type=""Captcha"">
      <DisplayName>$Ctd-User,Captcha-DisplayName</DisplayName>
      <Description>$Ctd-User,Captcha-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Manager"" type=""Reference"">
      <DisplayName>$Ctd-User,Manager-DisplayName</DisplayName>
      <Description>$Ctd-User,Manager-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Department"" type=""ShortText"">
      <DisplayName>$Ctd-User,Department-DisplayName</DisplayName>
      <Description>$Ctd-User,Department-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <Visible>true</Visible>
      </Configuration>
    </Field>
    <Field name=""Languages"" type=""ShortText"">
      <DisplayName>$Ctd-User,Languages-DisplayName</DisplayName>
      <Description>$Ctd-User,Languages-Description</Description>
      <Indexing>
        <Analyzer>Standard</Analyzer>
      </Indexing>
      <Configuration>
        <Visible>true</Visible>
      </Configuration>
    </Field>
    <Field name=""Phone"" type=""ShortText"">
      <DisplayName>$Ctd-User,Phone-DisplayName</DisplayName>
      <Description>$Ctd-User,Phone-Description</Description>
      <Configuration>
        <Regex>(^\d*([-\s\+\(\)]\d*)*$)?</Regex>
        <Visible>true</Visible>
      </Configuration>
    </Field>
    <Field name=""TrashDisabled"" type=""Boolean"">
      <DisplayName>$Ctd-User,TrashDisabled-DisplayName</DisplayName>
      <Description>$Ctd-User,TrashDisabled-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <DefaultValue>false</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""VersioningMode"" type=""VersioningMode"">
      <DisplayName>$Ctd-User,VersioningMode-DisplayName</DisplayName>
      <Description>$Ctd-User,VersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""0"">$Ctd-User,VersioningMode-0</Option>
          <Option selected=""true"" value=""1"">$Ctd-User,VersioningMode-1</Option>
          <Option value=""2"">$Ctd-User,VersioningMode-2</Option>
          <Option value=""3"">$Ctd-User,VersioningMode-3</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""Gender"" type=""Choice"">
      <DisplayName>$Ctd-User,Gender-DisplayName</DisplayName>
      <Description>$Ctd-User,Gender-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""..."">$Ctd-User,Gender-...</Option>
          <Option value=""Female"">$Ctd-User,Gender-Female</Option>
          <Option value=""Male"">$Ctd-User,Gender-Male</Option>
        </Options>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""MaritalStatus"" type=""Choice"">
      <DisplayName>$Ctd-User,MaritalStatus-DisplayName</DisplayName>
      <Description>$Ctd-User,MaritalStatus-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""..."">$Ctd-User,MaritalStatus-...</Option>
          <Option value=""Single"">$Ctd-User,MaritalStatus-Single</Option>
          <Option value=""Married"">$Ctd-User,MaritalStatus-Married</Option>
        </Options>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""BirthDate"" type=""DateTime"">
      <DisplayName>$Ctd-User,BirthDate-DisplayName</DisplayName>
      <Configuration>
        <DateTimeMode>Date</DateTimeMode>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Education"" type=""LongText"">
      <DisplayName>$Ctd-User,Education-DisplayName</DisplayName>
      <Description>$Ctd-User,Education-Description</Description>
      <Configuration>
        <TextType>LongText</TextType>
        <ControlHint>sn:EducationEditor</ControlHint>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""TwitterAccount"" type=""ShortText"">
      <DisplayName>$Ctd-User,TwitterAccount-DisplayName</DisplayName>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""FacebookURL"" type=""ShortText"">
      <DisplayName>$Ctd-User,FacebookURL-DisplayName</DisplayName>
      <Description>$Ctd-User,FacebookURL-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LinkedInURL"" type=""ShortText"">
      <DisplayName>$Ctd-User,LinkedInURL-DisplayName</DisplayName>
      <Description>$Ctd-User,LinkedInURL-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Language"" type=""Choice"">
      <DisplayName>$Ctd-User,Language-DisplayName</DisplayName>
      <Description>$Ctd-User,Language-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowExtraValue>false</AllowExtraValue>
        <Options>
          <Option value=""en"" selected=""true"">$Ctd-User,Language-En</Option>
          <Option value=""hu"">$Ctd-User,Language-Hu</Option>
        </Options>
      </Configuration>
    </Field>
    <Field name=""FollowedWorkspaces"" type=""Reference"">
      <DisplayName>$Ctd-User,FollowedWorkspaces-DisplayName</DisplayName>
      <Description>$Ctd-User,FollowedWorkspaces-Description</Description>
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
        <AllowMultiple>true</AllowMultiple>
        <AllowedTypes>
          <Type>Workspace</Type>
        </AllowedTypes>
      </Configuration>
    </Field>
    <Field name=""ProfilePath"" type=""ShortText"">
      <DisplayName>$Ctd-User,ProfilePath-DisplayName</DisplayName>
      <Description>$Ctd-User,ProfilePath-Description</Description>
      <Configuration>
        <ReadOnly>true</ReadOnly>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""LastLoggedOut"" type=""DateTime"">
      <DisplayName>$Ctd-User,LastLoggedOut-DisplayName</DisplayName>
      <Description>$Ctd-User,LastLoggedOut-Description</Description>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  74. UserProfile
			{ "UserProfile", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""UserProfile"" parentType=""Workspace"" handler=""SenseNet.ContentRepository.UserProfile"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-UserProfile,DisplayName</DisplayName>
  <Description>$Ctd-UserProfile,Description</Description>
  <Icon>UserProfile</Icon>
  <AllowedChildTypes>
    Blog,DocumentLibrary,EventList,MemoList,LinkList,TaskList,ImageLibrary,Posts,CustomList
  </AllowedChildTypes>
  <Fields>
    <Field name=""IsWallContainer"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Advanced</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
        <DefaultValue>true</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""IsCritical"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Manager"" type=""Reference"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Deadline"" type=""DateTime"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsActive"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""User"" type=""Reference"">
      <DisplayName>$Ctd-UserProfile,User-DisplayName</DisplayName>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  75. WebServiceApplication
			{ "WebServiceApplication", @"<ContentType name=""WebServiceApplication"" parentType=""Application"" handler=""SenseNet.ApplicationModel.Application"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition""><DisplayName>$Ctd-WebServiceApplication,DisplayName</DisplayName><Description>$Ctd-WebServiceApplication,Description</Description><Icon>File</Icon><Fields><Field name=""Binary"" type=""Binary""><DisplayName>$Ctd-WebServiceApplication,Binary-DisplayName</DisplayName><Description>$Ctd-WebServiceApplication,Binary-Description</Description><Configuration><IsText>true</IsText></Configuration></Field></Fields></ContentType>" },
			#endregion
			#region  76. Workspace
			{ "Workspace", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""Workspace"" parentType=""Folder"" handler=""SenseNet.ContentRepository.Workspaces.Workspace"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-Workspace,DisplayName</DisplayName>
  <Description>$Ctd-Workspace,Description</Description>
  <Icon>Workspace</Icon>
  <AllowedChildTypes>Page,Folder,DocumentLibrary,ImageLibrary,EventList,MemoList,LinkList,TaskList,CustomList,Workspace</AllowedChildTypes>
  <Fields>
    <Field name=""DisplayName"" type=""ShortText"">
      <DisplayName>$Ctd-Workspace,DisplayName-DisplayName</DisplayName>
    </Field>
    <Field name=""Description"" type=""LongText"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""Manager"" type=""Reference"">
      <DisplayName>$Ctd-Workspace,Manager-DisplayName</DisplayName>
      <Description>$Ctd-Workspace,Manager-Description</Description>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>User</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/IMS</Path>
          <Path>/Root</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""Deadline"" type=""DateTime"">
      <DisplayName>$Ctd-Workspace,Deadline-DisplayName</DisplayName>
      <Configuration>
        <DateTimeMode>DateAndTime</DateTimeMode>
      </Configuration>
    </Field>
    <Field name=""IsActive"" type=""Boolean"">
      <DisplayName>$Ctd-Workspace,IsActive-DisplayName</DisplayName>
      <Description>$Ctd-Workspace,IsActive-Description</Description>
      <Configuration>
        <Compulsory>true</Compulsory>
        <DefaultValue>true</DefaultValue>
      </Configuration>
    </Field>
    <Field name=""WorkspaceSkin"" type=""Reference"">
      <DisplayName>$Ctd-Workspace,WorkspaceSkin-DisplayName</DisplayName>
      <Configuration>
        <AllowMultiple>false</AllowMultiple>
        <AllowedTypes>
          <Type>Skin</Type>
        </AllowedTypes>
        <SelectionRoot>
          <Path>/Root/Skins</Path>
        </SelectionRoot>
      </Configuration>
    </Field>
    <Field name=""IsCritical"" type=""Boolean"">
      <DisplayName>$Ctd-Workspace,IsCritical-DisplayName</DisplayName>
      <Description>$Ctd-Workspace,IsCritical-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Advanced</VisibleEdit>
        <VisibleNew>Advanced</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsWallContainer"" type=""Boolean"">
      <DisplayName>$Ctd-Workspace,IsWallContainer-DisplayName</DisplayName>
      <Description>$Ctd-Workspace,IsWallContainer-Description</Description>
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""AllowedChildTypes"" type=""AllowedChildTypes"">
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableVersioningMode"" type=""InheritableVersioningMode"">
      <Description>$Ctd-Workspace,WorkspaceInheritableVersioningMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""InheritableApprovingMode"" type=""InheritableApprovingMode"">
      <Description>$Ctd-Workspace,WorkspaceInheritableApprovingMode-Description</Description>
      <Configuration>
        <VisibleBrowse>Show</VisibleBrowse>
        <VisibleEdit>Show</VisibleEdit>
        <VisibleNew>Show</VisibleNew>
      </Configuration>
    </Field>
    <Field name=""IsFollowed"" type=""Boolean"">
      <Configuration>
        <VisibleBrowse>Hide</VisibleBrowse>
        <VisibleEdit>Hide</VisibleEdit>
        <VisibleNew>Hide</VisibleNew>
      </Configuration>
    </Field>
  </Fields>
</ContentType>" },
			#endregion
			#region  77. XmlFieldSetting
			{ "XmlFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""XmlFieldSetting"" parentType=""FieldSettingContent"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-XmlFieldSetting,DisplayName</DisplayName>
  <Icon>addxmlfield</Icon>
  <Fields />
</ContentType>" },
			#endregion
			#region  78. YesNoFieldSetting
			{ "YesNoFieldSetting", @"<?xml version=""1.0"" encoding=""utf-8""?>
<ContentType name=""YesNoFieldSetting"" parentType=""ChoiceFieldSetting"" handler=""SenseNet.ContentRepository.Schema.FieldSettingContent"" xmlns=""http://schemas.sensenet.com/SenseNet/ContentRepository/ContentTypeDefinition"">
  <DisplayName>$Ctd-YesNoFieldSetting,DisplayName</DisplayName>
  <Icon>addyesnofield</Icon>
  <Fields />
</ContentType>" },
			#endregion
        });

        public IDictionary<string, string> Blobs =>
            new ReadOnlyDictionary<string, string>(new Dictionary<string, string>
            {
                #region  1.Indexing .settings
                { "Binary:/Root/System/Settings/Indexing.settings", @"{
    ForceReopenFrequencyInSeconds: 30,
    TextExtractors: {
    }
}"},
                #endregion
                #region  2. Logging.settings
                { "Binary:/Root/System/Settings/Logging.settings", @"{
    Trace: {
		ContentOperation: false,
		Database: false,
		Index: false,
		IndexQueue: false,
		Query: false,
		Repository: false,
		Messaging: false,
		Security: false,
		SecurityQueue: false,
		System: false,
		Web: false,
		Workflow: false,
		TaskManagement: false,
		Test: false,
		Event: false,
		Custom: false,
    }
}"},
                #endregion
                #region  3. MailProcessor.settings
                { "Binary:/Root/System/Settings/MailProcessor.settings", @"{
	MailProcessingMode: ""ExchangePull"",

                        StatusPollingIntervalInMinutes: 120,
                        PushNotificationServicePath: ""http://example.com{0}?action=ExchangeService.asmx"",
                        ExchangeAddress: ""https://exchangeserveraddress/EWS/Exchange.asmx"",
                        POP3: {

                        Server: ""pop3.live.com"",
                        Password: """",
                        Port: 995,
                        SSL: true
                    }
                }"},
                #endregion
                #region  4. OAuth.settings
                { "Binary:/Root/System/Settings/OAuth.settings", @"{
	UserType: ""User"",
	Domain: ""Public""
}"},
                #endregion
                #region  5. Portal.settings
                { "Binary:/Root/System/Settings/Portal.settings", @"{
	ClientCacheHeaders: [
		{ ContentType: ""PreviewImage"", MaxAge: 1 },
		{ Extension: ""jpeg"", MaxAge: 604800 },
		{ Extension: ""gif"", MaxAge: 604800 },
		{ Extension: ""jpg"", MaxAge: 604800 },
		{ Extension: ""png"", MaxAge: 604800 },
		{ Extension: ""swf"", MaxAge: 604800 },
		{ Extension: ""css"", MaxAge: 600 },
		{ Extension: ""js"", MaxAge: 600 }
	],
	UploadFileExtensions: {
		""jpg"": ""Image"",
		""jpeg"": ""Image"",
		""gif"": ""Image"",
		""png"": ""Image"",
		""bmp"": ""Image"",
		""svg"": ""Image"",
		""svgz"": ""Image"",
		""tif"": ""Image"",
		""tiff"": ""Image"",
		""xaml"": ""WorkflowDefinition"",
		""DefaultContentType"": ""File""
	},
	BinaryHandlerClientCacheMaxAge: 600,
	PermittedAppsWithoutOpenPermission: ""Details""
}"},
                #endregion
                #region  6. Sharing.settings
                { "Binary:/Root/System/Settings/Sharing.settings", @"{
   ""NotificationEnabled"": false
}"},
                #endregion
                #region  7. TaskManagement.settings
                { "Binary:/Root/System/Settings/TaskManagement.settings", @"{
    TaskManagementUrl: """",
    TaskManagementApplicationUrl: ""http://localhost"",
	TaskManagementAppId: ""SenseNet""
}"},
                #endregion
                #region  8. UserProfile.settings
                { "Binary:/Root/System/Settings/UserProfile.settings", @"{
User: {ProfileType: ""UserProfile"", ProfilesTarget: ""/Root""}
}"},
                #endregion
            });

        public IList<string> Permissions => new List<string>
        {
            // "+E1|Normal|+G1:______________+,Normal|+G2:_____________+_";


            // RECORD STRUCTURE:
            // Inherited: +, breaked: -
            // EntityId
            // |
            // EntryType: Normal
            // |
            // Global: +, Local only: -
            // IdentityId
            // :
            // Permission bits (64 chars): Not set: _, Allow: +, Deny: -
            //---------------------------------------------------------------------------
            // See: See
            // Pre: Preview
            // PWa: PreviewWithoutWatermark
            // PRd: PreviewWithoutRedaction
            // Opn: Open
            // OpM: OpenMinor
            // Sav: Save
            // Pub: Publish
            // Chk: ForceCheckin
            // Add: AddNew
            // Apr: Approve
            // Del: Delete
            // ReV: RecallOldVersion
            // DeV: DeleteOldVersion
            // ReP: SeePermissions
            // WrP: SetPermissions
            // Run: RunApplication
            // LST: ManageListsAndWorkspaces
            // Own: TakeOwnership
            //---------------------------------------------------------------------------
            //                                                            WrP Del Pub PRd
            //                                                         Own ReP Apr Sav PWa
            //                                                          LST DeV Add OpM Pre
            //            |            custom            ||   unused  |  Run ReV Chk Opn See
            //            3333333333333333222222222222222211111111111111110000000000000000
            //            FEDCBA9876543210FEDCBA9876543210FEDCBA9876543210FEDCBA9876543210
            "+2|Normal|+1:_____________________________________________+++++++++++++++++++",
            "+2|Normal|+7:_____________________________________________+++++++++++++++++++",
            "+2|Normal|+8:_______________________________________________________________+",
        };
    }
}
