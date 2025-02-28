pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                // Checkout code from version control
                git 'https://github.com/Roberto-Sacramento/hrorangeautomation.git'
                withCredentials([usernamePassword(credentialsId: 'your-credentials-id', usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD')]) {
                    sh 'echo $USERNAME'
                    sh 'echo $PASSWORD'
            }
        }
        
        stage('Build') {
            steps {
                // Build the application
                sh './build.sh'
            }
        }
        
        stage('Test') {
            steps {
                // Run automated tests
                sh './test.sh'
            }
        }
        
        stage('Deploy') {
            steps {
                // Deploy the application
                sh './deploy.sh'
            }
        }
     }

     post {
        always {
            // Clean up after the build
            cleanWs()
        }
        success {
            // Notify success
            echo 'Build and deployment successful!'
        }
        failure {
            // Notify failure
            echo 'Build or deployment failed.'
        }
      }

    }
}

