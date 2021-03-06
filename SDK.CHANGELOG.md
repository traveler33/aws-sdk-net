### 3.1.16.0 (2015-10-01 21:11 UTC)
* CloudTrail (3.1.1.0)
	* Added new APIs for AWS CloudTrail: AddTags, ListTags, RemoveTags, and ListPublicKeys. This release of CloudTrail includes support for log file integrity validation, log encryption with AWS KMS–Managed Keys (SSE-KMS), and trail tagging.
* Elasticsearch (3.0.0.0)
	* Added support for the new Amazon Elasticsearch Service.
* RDS (3.1.2.0)
	* Added support for t2.large DB instance, support for copying tags to snapshot, and other minor updates.
* WorkSpaces (3.1.1.0)
	* Added support for user volume encryption.

### 3.1.15.0 (2015-09-29 23:12 UTC)
* CloudFormation (3.1.1.0)
	* Added new DescribeAccountLimits API and optional ResourceTypes parameter for CreateStack and UpdateStack APIs.
* EC2 (3.1.3.0)
	* Added support for the new ModifySpotFleetRequest API.
* SimpleEmail (3.1.1.0)
	* Amazon Simple Email Service can now accept incoming emails. You can configure Amazon SES to deliver messages to an Amazon S3 bucket, call an AWS Lambda function, publish notifications to Amazon SNS, drop messages, or bounce messages. Added new cmdlets to support this feature.

### 3.1.14.1 (2015-09-24 22:17 UTC)
* CognitoIdentity (3.1.0.2)
	* Documentation update.

### 3.1.14.0 (2015-09-17 19:21 UTC)
* CloudWatchLogs (3.1.2.0)
	* Added support for exporting log data from Log Groups to Amazon S3 Buckets.

### 3.1.13.0 (2015-09-16 19:35 UTC)
* S3 (3.1.3.0)
	* Added support for the new STANDARD_IA storage class and for multiple lifecycle transitions.

### 3.1.12.0 (2015-09-15 20:11 UTC)
* EC2 (3.1.2.0)
	* Added DataEncryptionKeyId and StateMessage properties to the Amazon.EC2.Model.Snapshot class, this data is returned by the DescribeSnapshots operation. Added AllocationStrategy property to the Amazon.EC2.Model.SpotFleetRequestConfigData class, this data is used by the RequestSpotFleet operation.
* ElasticFileSystem (3.1.1.0)
	* Added MountTargetId to Amazon.ElasticFileSystem.Model.DescribeMountTargetsRequest.
* MobileAnalytics (3.1.1.1)
	* Fixed FxCop violations, and minor refactoring.
* Route53 (3.1.1.0)
	* Added support for calculated and latency health checks.

### 3.1.11.0 (2015-09-10 17:43 UTC)
* ElasticMapReduce (3.1.1.0)
	* Deprecated DescribeJobFlows API.
* IdentityManagement (3.1.1.0)
	* Add support for IAM policy simulator.
* ImportExport (3.1.1.0)
	* Documentation update for ImportExport client.
* Kinesis (3.1.1.0)
	* Add timestamp field to Amazon.Kinesis.Model.Record type.
* Lambda (3.1.1.0)
	* Deprecated InvokeAsync API
* MachineLearning (3.1.1.0)
	* Documentation update for Amazon Machine Learning client.

### 3.1.10.1 (2015-09-04 20:30 UTC)
* Core 3.1.1.1
	* Included pull request https://github.com/aws/aws-sdk-net/pull/242 to fix signing issues for endpoints with a path component.

### 3.1.10.0 (2015-09-03 20:56 UTC)
* DynamoDBv2 (3.1.1.0)
	* Added enum support for DynamoDB DataModel.
* StorageGateway (3.1.1.0)
	* Add support for tagging StorageGateway resources.

### 3.1.9.0 (2015-08-31 21:22 UTC)
* EC2 (3.1.1.0)
	* Add support for spot fleet instance weights.

### 3.1.8.0 (2015-08-27 23:50 UTC)
* ConfigService (3.1.1.0)
	* Added support for ListDiscoveredResources.

### 3.1.7.0 (2015-08-27 00:39 UTC)
* MobileAnalytics (3.1.1.0)
	* Added MobileAnalyticsErrorEvent to Amazon Mobile Analytics and minor improvements.
* Core 3.1.1.0
	* Service packages updated to require new core, which includes FileLogger for PCL.

### 3.1.6.0 (2015-08-25 18:01 UTC)
* CodePipeline (3.1.1.0)
	* Add support for KMS encryption keys on S3 artifact stores.

### 3.1.5.0 (2015-08-12 20:11 UTC)
* ElasticBeanstalk (3.1.1.0)
	* Add Elastic Beanstalk client support for environment health.
* MobileAnalytics (3.1.0.2)
	* Updated to need new core version 3.1.0.2
	* Updated documentation
* S3 (3.1.2.0)
	* Updated S3 TransferUtility to retry a failed download without discarding the bytes that were already downloaded
* Core 3.1.0.2

### 3.1.4.0 (2015-08-06 15:55 UTC)
* SimpleWorkflow (3.1.1.0)
	* Update SWF client for Lambda support

### 3.1.3.0 (2015-08-04 21:59 UTC)
* DeviceFarm (3.1.1.0)
	* Update DeviceFarm client with latest model, adding support for iOS and retrieving account settings.

### 3.1.2.1 (2015-08-04 00:50 UTC)
* CloudSearchDomain (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Glacier (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Lambda (3.1.0.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* S3 (3.1.1.1)
	* Updated to need new core version 3.1.0.1
	* Picking up the version of PCL core that fixes SigV4 streaming signature issue.
* Core 3.1.0.1
	* Fix PCL SigV4 signing issue where SHA256 hash is not always calculated correctly.

### 3.1.2.0 (2015-07-31 00:36 UTC)
* OpsWorks (3.1.1.0)
	* Add support for ECS clusters.
* RDS (3.1.1.0)
	* Add support for Amazon Aurora.

### 3.1.1.0 (2015-07-28 23:37 UTC)
* CloudWatchLogs (3.1.1.0)
	* Adding 4 new APIs: PutDestination, PutDestinationPolicy, DescribeDestinations and DeleteDestination
* S3 (3.1.1.0)
	* Support for new storage class headers on GET/HEAD requests.
	* Enhancements to S3 event notifications
		* Support for Deletes.
		* Support for Bucket Change events like policy changes and lifecycle changes
		* Support for filtering on object names including prefixes and suffixes.

### 3.1.0.0 (2015-07-28 20:30 UTC)
* The Version 3 of AWS SDK for .NET is out of preview and promoted to general availability.
* All service SDKs and Core assemblies are set to version 3.1.0.0 for this release.
* Xamarin support added to Portable Class Library (PCL) version of the SDK. The Xamarin and PCL versions of the SDK are available as public preview.
* Additional Changes
	* Pull request [222](https://github.com/aws/aws-sdk-net/pull/222) - Fix to code that resolves location of .aws\credentials file.
	* Fixed issue with setting ServiceURL for DynamoDB Streams client.

### 3.0.6.0 (2015-07-10 00:22 UTC)
* AutoScaling (3.0.2.0)
	* Step scaling policies allow customers to scale their Auto Scaling groups based on the magnitude of the alarm breach.
* CloudFront (3.0.2.0)
	* Amazon CloudFront now lets you configure a maximum time-to-live (TTL) and a default TTL to specify how long CloudFront caches your objects in edge locations.
* CodeCommit (3.0.0.0)
	* AWS CodeCommit is a secure, highly scalable, managed source control service that hosts private Git repositories.
* CodePipeline (3.0.0.0)
	* AWS CodePipeline is a continuous delivery service that enables you to model, visualize, and automate the steps required to release your software.
* CognitoIdentity (3.0.1.1)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* CognitoSync (3.0.0.3)
	* The following Amazon Cognito operations now throw a ConcurrentModificationException when more than one requests are sent for modification of resources in parallel to the services
* ConfigService (3.0.1.0)
	* You can now set up AWS Config to record changes for specific resource types.
* EC2 (3.0.5.0)
	* You can now optionally enable encryption using AWS KMS keys when copying an unencrypted EBS snapshot.
* ECS (3.0.3.0)
	* You can now use the UDP protocol with containers on Amazon EC2 Container Service (ECS).
* Glacier (3.0.2.0)
	* Glacier vaults now support tagging.
* IdentityManagement (3.0.1.0)
	* You can upload SSH public keys to IAM and use those keys for	authentication with AWS CodeCommit. 
* Lambda (3.0.2.0)
	* You can now develop your AWS Lambda function code using Java.
* OpsWorks (3.0.2.0)
	* You can now manage updates of the agent software running on instances managed by AWS OpsWorks. 
* Redshift (3.0.1.0)
	* Redshift supports automatic cross-region backups for your KMS encrypted clusters for disaster recover.
* SimpleEmail (3.0.1.0)
	* Amazon Simple Email Service (Amazon SES) adds support for cross-account sending.
* Core 3.0.0.4

### 3.0.5.0 (2015-06-20 06:52 UTC)
* ECS (3.0.2.0)
	* You can now choose the sort order for task definitions, deregister task definitions, and override task definition environment variables when running a task.

### 3.0.4.0 (2015-06-19 22:54 UTC)
* AutoScaling (3.0.1.0)
* EC2 (3.0.4.0)
	* Regen EC2 for latest API changes. The update contains the new VPC Flow Logs feature.
* ECS (3.0.1.0)
	* Regen ECS with latest service API updates.
