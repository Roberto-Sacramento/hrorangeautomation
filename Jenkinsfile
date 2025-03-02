pipeline {
    agent any

    stages {
        stage('Checkout') {
            steps {
                git url: 'https://github.com/Roberto-Sacramento/hrorangeautomation.git', branch: 'master'
            }
        }

        stage('Building') {
            steps {
                
            }
        }

        stage('Testing') {
            steps {
                sh './test.sh' // Or your test command, such as 'mvn test'
            }
        }

        stage('Deploy') {
            steps {
                sh './deploy.sh' // Or your deployment command, such as 'kubectl apply -f deployment.yaml'
            }
        }
    }

    post {
        always {
            echo 'Pipeline completed'
        }
        success {
            echo 'Pipeline succeeded'
        }
        failure {
            echo 'Pipeline failed'
        }
    }
}