pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout code from version control
                git 'https://github.com/Roberto-Sacramento/hrorangeautomation.git'
            }
        }
        
        stage('Build') {
            steps {
                // Build the application
                script {
                    try {
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
