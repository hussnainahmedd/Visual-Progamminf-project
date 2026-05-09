window.renderPieChart = (canvasId, labels, data, colors) => {
    const ctx = document.getElementById(canvasId);
    if (!ctx) return;

    if (ctx._chartInstance) ctx._chartInstance.destroy();

    ctx._chartInstance = new Chart(ctx, {
        type: 'pie',
        data: {
            labels: labels,
            datasets: [{
                data: data,
                backgroundColor: colors,
                borderWidth: 2,
                borderColor: '#fff'
            }]
        },
        options: {
            responsive: false,
            plugins: {
                legend: {
                    position: 'right',
                    labels: { font: { size: 11 } }
                }
            }
        }
    });
};

window.renderLineChart = (canvasId, labels, datasets) => {
    const ctx = document.getElementById(canvasId);
    if (!ctx) return;
    if (ctx._chartInstance) ctx._chartInstance.destroy();
    ctx._chartInstance = new Chart(ctx, {
        type: 'line',
        data: {
            labels: labels,
            datasets: datasets
        },
        options: {
            responsive: false,
            plugins: { legend: { position: 'top' } },
            scales: {
                y: { beginAtZero: true, ticks: { stepSize: 1 } }
            }
        }
    });
};
window.applyTheme = function (isDark) {
    if (isDark) {
        document.body.classList.add('dark-mode');
    } else {
        document.body.classList.remove('dark-mode');
    }
    localStorage.setItem('darkMode', isDark.ToString ? isDark.ToString() : String(isDark));
};

window.getLocalStorage = function (key) {
    return localStorage.getItem(key);
};

window.setLocalStorage = function (key, value) {
    localStorage.setItem(key, value);
};

// Auto-apply theme on page load
(function () {
    const dark = localStorage.getItem('darkMode');
    if (dark === 'True') {
        document.body.classList.add('dark-mode');
    }
})();