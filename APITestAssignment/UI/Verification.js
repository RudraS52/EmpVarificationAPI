
    const form = document.getElementById('verification-form');
    const submitButton = document.getElementById('submit-button');
    const verificationResult = document.getElementById('verification-result');

  submitButton.addEventListener('click', async (e) => {
        e.preventDefault();
    const employeeId = document.getElementById('employee-id').value;
    const companyName = document.getElementById('company-name').value;
    const verificationCode = document.getElementById('verification-code').value;

    const apiEndpoint = '/api/verify-employment';
    const payload = {
        employeeId: parseInt(employeeId),
    companyName,
    verificationCode
    };

    try {
      const response = await fetch(apiEndpoint, {
        method: 'POST',
    headers: {
        'Content-Type': 'application/json'
        },
    body: JSON.stringify(payload)
      });

    const result = await response.json();
    verificationResult.textContent = result.verificationResult;
    } catch (error) {
        console.error(error);
    verificationResult.textContent = 'Error verifying employment';
    }
  });


