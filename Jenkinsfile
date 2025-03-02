pipeline {
    agent {
        docker true
    }

    stages {
        stage('Checkout') {
            steps {
                // Checkout code from version control
                git 'https://github.com/Roberto-Sacramento/hrorangeautomation.git'
                // List workspace contents
                sh 'ls -la'
            }
        }
        
        stage('Build') {
            steps {
                // Build the application
                script {
                    try {
                        // List workspace contents again before running the script
                        sh 'ls -la'
                        sh './build.sh'
                    } catch (Exception e) {
                        echo "Build failed: ${e.message}"
                        currentBuild.result = 'FAILURE'
                        throw e
                    }
                }
            }
        }
        
        stage('Test') {
            steps {
                // Run automated tests
                script {
                    try {
                        sh './test.sh'
                    } catch (Exception e) {
                        echo "Tests failed: ${e.message}"
                        currentBuild.result = 'FAILURE'
                        throw e
                    }
                }
            }
        }
        
        stage('Deploy') {
            steps {
                // Deploy the application
                script {
                    try {
                        sh './deploy.sh'
                    } catch (Exception e) {
                        echo "Deployment failed: ${e.message}"
                        currentBuild.result = 'FAILURE'
                        throw e
                    }
                }
            }
        }
    }
}
