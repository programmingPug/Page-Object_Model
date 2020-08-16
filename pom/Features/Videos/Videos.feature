Feature: Video Controls
	In order to control a video
	As a user
	I want to manipulate video controls
	
Scenario: Pause video playback
	Given I have logged into the application
	And I have started playing a video
	When I press pause
	Then the video should be paused